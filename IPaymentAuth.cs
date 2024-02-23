using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal interface IPaymentAuth
    {
        public void AuthViaSMS();
        public void AuthViaEmail();
    }
}
