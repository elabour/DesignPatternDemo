using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPaymentExample
{
    internal class Program
    {
        public interface IPayment
        {
            void Pay(double amount);
        }
        // Real subject
        public class RealPayment : IPayment
        {
            public void Pay(double amount)
            {
                Console.WriteLine($"Payment of {amount} processed successfully.");
            }
        }

        // Proxy
        public class PaymentProxy : IPayment
        {
            private RealPayment _realPayment = new RealPayment();
            private string _method;
            public PaymentProxy(string method)
            {
                _method = method;
            }

            public void Pay(double amount)
            {
              _realPayment.Pay(amount);
            }
        }

        static void Main(string[] args)
        {
            IPayment cash = new PaymentProxy("Cash");
            cash.Pay(100);

            IPayment card = new PaymentProxy("Credit Card");
            card.Pay(250);

            IPayment atm = new PaymentProxy("ATM");
            atm.Pay(500);
        }
    }
}
