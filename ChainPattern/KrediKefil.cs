using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern
{
    class KrediKefil : KrediCevapBase
    {
        public override void ExecuteProcess(Customer c)
        {
            if (base.KrediOnay)
            {
                if (c.Kefidurum)
                    base.KrediOnay = true;
                else
                    base.KrediOnay = false;
            }

        }
    }
}
