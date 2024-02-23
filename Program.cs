namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROBLEMS:
             * 
             * -S-
             * Everything is going on in one single class - god class.
             * It has too many responsibilities and becomes overly complex to maintain.
             * 
             * -O-
             * If we want to add new functionality, we should not change existing code.
             * Instead, we should write the code in a way that it will accept new functionality
             * if it implements a certain interface
             * 
             * -L-
             * 
             * 
             */
            Item paper = new Item() { Name = "Paper", Price = 1M, Quantity = 50 };
            Item pencil = new Item() { Name = "Pencil", Price = 5.25M, Quantity = 4 };
            Item eraser = new Item() { Name = "Eraser", Price = 1.99M, Quantity = 1 };

            Order order = new Order();

            order.AddItem(paper);
            order.AddItem(pencil);
            order.AddItem(eraser);

            PaymentProcess paymentProcessCard = new PaymentProcessCard();
            PaymentProcess paymentProcessCash = new PaymentProcessCash();
            PaymentProcess paymentProcessmagicBeans = new PaymentProcessMagicBeans();

            paymentProcessCard.Pay(order, "A123");
            paymentProcessCash.Pay(order, "A123");
            paymentProcessmagicBeans.Pay(order, "A123"); // we finally accept magic beans!
        }
    }
}
