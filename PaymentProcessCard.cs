using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessCard(string securityCode) : PaymentProcess, ISecurityCode, IPaymentSMSAuth
    {
        public string SecurityCode { get; set; } = securityCode;

        public void AuthViaSMS()
        {
            Console.WriteLine($"Authorized via security code {SecurityCode}");
        }

        public override void Pay(Order order)
        {
            Console.WriteLine($"Processing -card- payment for {order.OrderPrice()}");
            order.Status = 1;
        }
    }
}
