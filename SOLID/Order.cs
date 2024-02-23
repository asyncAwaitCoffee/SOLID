using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal class Order
    {
        public byte Status { get; set; } = 0;
        public List<Item> Items { get; set; } = [];
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public decimal OrderPrice()
        {
            return Items.Aggregate(0M, (sum, item) => sum + item.Price);
        }
    }
}
