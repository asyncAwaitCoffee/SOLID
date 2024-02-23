using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessCard(string securityCode, Authorizer smsAuthorizer) : PaymentProcess, ISecurityCode
    {
        public string SecurityCode { get; set; } = securityCode;
        public Authorizer SMSAuthorizer { get; set; } = smsAuthorizer;

        public override void Pay(Order order)
        {
            SMSAuthorizer.Authorize(SecurityCode);
            Console.WriteLine($"Processing -card- payment for {order.OrderPrice()}");
            order.Status = 1;
        }
    }
}
