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
             * if it implements a certain interface.
             * 
             * -L-
             * It should be possible to pass any child class of one parent class to the program
             * without breaking its logic.
             * 
             * -I-
             * The class should not depend on parts of interface that it does not need,
             * thereby avoiding empty implementations.
             * 
             * -D-
             * Depend on abstractions - not concrete implementations.
             * 
             */
            Item paper = new Item() { Name = "Paper", Price = 1M, Quantity = 50 };
            Item pencil = new Item() { Name = "Pencil", Price = 5.25M, Quantity = 4 };
            Item eraser = new Item() { Name = "Eraser", Price = 1.99M, Quantity = 1 };

            Order order = new Order();

            order.AddItem(paper);
            order.AddItem(pencil);
            order.AddItem(eraser);

            AuthorizerSMS authorizerSMS = new AuthorizerSMS();
            AuthorizerEmail authorizerEmail = new AuthorizerEmail();

            PaymentProcessCard paymentProcessCard = new PaymentProcessCard("A123", authorizerSMS);
            PaymentProcessCash paymentProcessCash = new PaymentProcessCash("A123", authorizerSMS);

            MagicEmail magicEmail = new MagicEmail() { Address = "magic@email.world" };
            TelepathicConfirm telepathicConfirm = new TelepathicConfirm() { Address = "thoughts@manager.head" };
            PaymentProcessMagicBeans paymentProcessmagicBeansA = new PaymentProcessMagicBeans(magicEmail, authorizerEmail);
            PaymentProcessMagicBeans paymentProcessmagicBeansB = new PaymentProcessMagicBeans(telepathicConfirm, authorizerEmail);

            paymentProcessCard.Pay(order);
            paymentProcessCash.Pay(order);
            paymentProcessmagicBeansA.Pay(order);
            paymentProcessmagicBeansB.Pay(order);
        }
    }
}
