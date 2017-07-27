using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern
{
    public abstract class KrediCevapBase
    {
        public bool KrediOnay;

        protected KrediCevapBase nextoperation;

        public void setNext(KrediCevapBase operation)
        {
            this.nextoperation = operation;
        }

        public void Execute(Customer c)
        {
            ExecuteProcess(c);

            if (this.nextoperation != null)
            {
                //her seferinde bir sonrakine aktarılır
                this.nextoperation.KrediOnay = this.KrediOnay;
                this.nextoperation.Execute(c);
            }
        }


        public abstract void ExecuteProcess(Customer c);
    }
}
