using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KrediCevapBase> kredioperasyonları = new List<KrediCevapBase>();

            kredioperasyonları.Add(new KrediKKBScore());
            kredioperasyonları.Add(new KrediKefil());
            kredioperasyonları.Add(new KrediFirmaDurum());

            kredioperasyonları[0].setNext(kredioperasyonları[1]);
            kredioperasyonları[1].setNext(kredioperasyonları[2]);


            kredioperasyonları[0].Execute(new Customer()
            {
                Kefidurum = true,
                kkbScore = 22
            });

            bool kredisonuc = kredioperasyonları[kredioperasyonları.Count - 1].KrediOnay;


            if (kredisonuc)
                Console.WriteLine("Kredi onaylandı");
            else
                Console.WriteLine("RED!");

            Console.ReadKey();
        }
    }
}
