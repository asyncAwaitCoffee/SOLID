using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessMagicBeans : PaymentProcess
    {
        public override void Pay(Order order, string securityCode)
        {
            Console.WriteLine($"Processing -magic beans- payment for {order.OrderPrice()} with security code {securityCode}");
            order.Status = 1;
        }
    }
}
