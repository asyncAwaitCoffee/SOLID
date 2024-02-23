using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessMagicBeans(MagicEmail securityEmail) : PaymentProcess, ISecurityEmail, IPaymentEmailAuth
    {
        public MagicEmail SecurityEmail { get; set; } = securityEmail;

        public void AuthViaEmail()
        {
            Console.WriteLine($"Authorized via email {SecurityEmail.Address}");
        }

        public override void Pay(Order order)
        {
            Console.WriteLine($"Processing -magic beans- payment for {order.OrderPrice()}.");
            order.Status = 1;
        }
    }
}
