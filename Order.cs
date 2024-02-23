using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Order
    {
        public byte Status { get; set; }
        public List<Item> Items { get; set; } = [];
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public decimal OrderPrice()
        {
            return Items.Aggregate(0M, ( sum, item) => sum + item.Price);
        }

        public void Pay(string paymenttype, string securityCode)
        {
            if (paymenttype == "cash")
            {
                Console.WriteLine($"Processing -cash- payment for {OrderPrice()} with security code {securityCode}");
            }
            else if (paymenttype == "card")
            {
                Console.WriteLine($"Processing -card- payment for {OrderPrice()} with security code {securityCode}");
            }
            else
            {
                throw new ArgumentException($"The -{paymenttype}- type of payment is not availible");
            }
        }
    }
}
