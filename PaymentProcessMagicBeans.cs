using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessMagicBeans(MagicEmail securityEmail, Authorizer emailAuthorizer) : PaymentProcess, ISecurityEmail
    {
        public MagicEmail SecurityEmail { get; set; } = securityEmail;
        public Authorizer EmailAuthorizer { get; set; } = emailAuthorizer;

        public override void Pay(Order order)
        {
            EmailAuthorizer.Authorize(SecurityEmail.Address);
            Console.WriteLine($"Processing -magic beans- payment for {order.OrderPrice()}.");
            order.Status = 1;
        }
    }
}
