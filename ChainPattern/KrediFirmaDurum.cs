using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern
{
    class KrediFirmaDurum : KrediCevapBase
    {
        public override void ExecuteProcess(Customer c)
        {
            if (base.KrediOnay)
            {
                base.KrediOnay = true;
            }
            
        }
    }
}
