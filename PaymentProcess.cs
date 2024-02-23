using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal abstract class PaymentProcess
    {
        public abstract void Pay(Order order, string securityCode);        
    }
}
