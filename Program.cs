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
             * It should be possible to pass any child class of one parent class to the program
             * without breaking its logic
             * 
             * -I-
             * The class should not depend on parts of interface that it does not need,
             * thereby avoiding empty implementations.
             * 
             */
            Item paper = new Item() { Name = "Paper", Price = 1M, Quantity = 50 };
            Item pencil = new Item() { Name = "Pencil", Price = 5.25M, Quantity = 4 };
            Item eraser = new Item() { Name = "Eraser", Price = 1.99M, Quantity = 1 };

            Order order = new Order();

            order.AddItem(paper);
            order.AddItem(pencil);
            order.AddItem(eraser);

            PaymentProcessCard paymentProcessCard = new PaymentProcessCard("A123");
            PaymentProcessCash paymentProcessCash = new PaymentProcessCash("A123");

            MagicEmail magicEmail = new MagicEmail() { Address = "magic@email.world" };
            PaymentProcessMagicBeans paymentProcessmagicBeans = new PaymentProcessMagicBeans(magicEmail);

            DoPaymentAuthViaSMS(paymentProcessCard);
            paymentProcessCard.Pay(order);

            DoPaymentAuthViaSMS(paymentProcessCash);
            paymentProcessCash.Pay(order);

            DoPaymentAuthViaEmail(paymentProcessmagicBeans);
            paymentProcessmagicBeans.Pay(order);





            void DoPaymentAuthViaSMS(IPaymentAuth paymentAuth)
            {
                paymentAuth.AuthViaSMS();
            }
            
            void DoPaymentAuthViaEmail(IPaymentAuth paymentAuth)
            {
                paymentAuth.AuthViaEmail();
            }
        }
    }
}
