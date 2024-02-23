using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessCash : PaymentProcess
    {
        public override void Pay(Order order, string securityCode)
        {
            Console.WriteLine($"Processing -cash- payment for {order.OrderPrice()} with security code {securityCode}");
            order.Status = 1;
        }
    }
}
