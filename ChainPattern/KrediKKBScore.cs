using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern
{
    class KrediKKBScore : KrediCevapBase
    {
        public override void ExecuteProcess(Customer c)
        {
            if (c.kkbScore > 1000)
                base.KrediOnay = true;
            else
                base.KrediOnay = false;
        }
    }
}
