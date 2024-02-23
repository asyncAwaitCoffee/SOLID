using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class PaymentProcessMagicBeans(MagicEmail securityEmail) : PaymentProcess, ISecurityEmail
    {
        public MagicEmail SecurityEmail { get; set; } = securityEmail;
        public override void Pay(Order order)
        {
            Console.WriteLine($"Processing -magic beans- payment for {order.OrderPrice()} with magic email {SecurityEmail.Address}");
            order.Status = 1;
        }
    }
}
