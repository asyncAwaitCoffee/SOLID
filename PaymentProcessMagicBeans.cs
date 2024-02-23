using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessMagicBeans(MagicEmail securityEmail) : PaymentProcess, ISecurityEmail, IPaymentAuth
    {
        public MagicEmail SecurityEmail { get; set; } = securityEmail;

        public void AuthViaEmail()
        {
            Console.WriteLine($"Authorized via email {SecurityEmail.Address}");
        }

        public void AuthViaSMS()
        {
            throw new NotImplementedException();
        }

        public override void Pay(Order order)
        {
            Console.WriteLine($"Processing -magic beans- payment for {order.OrderPrice()}.");
            order.Status = 1;
        }
    }
}
