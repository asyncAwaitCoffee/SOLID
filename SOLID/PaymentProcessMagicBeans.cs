using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal class PaymentProcessMagicBeans(MagicCommunication magicCommunication, Authorizer emailAuthorizer) : PaymentProcess, ISecurityMagicCommunication
    {
        public MagicCommunication TheMagicCommunication { get; set; } = magicCommunication;
        public Authorizer EmailAuthorizer { get; set; } = emailAuthorizer;

        public override void Pay(Order order)
        {
            EmailAuthorizer.Authorize(TheMagicCommunication.Address);
            Console.WriteLine($"Processing -magic beans- payment for {order.OrderPrice()}.");
            order.Status = 1;
        }
    }
}
