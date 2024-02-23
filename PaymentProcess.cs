using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcess
    {
        public void PayCash(Order order, string securityCode)
        {
            Console.WriteLine($"Processing -cash- payment for {order.OrderPrice()} with security code {securityCode}");
            order.Status = 1;
        }
        public void PayCard(Order order, string securityCode)
        {
            Console.WriteLine($"Processing -card- payment for {order.OrderPrice()} with security code {securityCode}");
            order.Status = 1;
        }
    }
}
