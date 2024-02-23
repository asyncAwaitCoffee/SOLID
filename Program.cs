namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item paper = new Item() { Name = "Paper", Price = 1M, Quantity = 50 };
            Item pencil = new Item() { Name = "Pencil", Price = 5.25M, Quantity = 4 };
            Item eraser = new Item() { Name = "Eraser", Price = 1.99M, Quantity = 1 };

            Order order = new Order();

            order.AddItem(paper);
            order.AddItem(pencil);
            order.AddItem(eraser);

            order.Pay("card", "A123");
            order.Pay("cash", "A123");
            //order.Pay("magic beans", "A123");
        }
    }
}
