using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternExample2
{
    // 1. Subject Interface (Simplified)
    public interface IPaymentProcessor
    {
        string ProcessPayment(string accountId, decimal amount);
    }

    // 2. Real Subject
    public class BankPaymentProcessor : IPaymentProcessor
    {
        public string ProcessPayment(string accountId, decimal amount)
        {
            // Core business logic (e.g., calling a remote bank API)
            Console.WriteLine($"[BANK] Authorizing transaction for Account:" +
                $" {accountId}, Amount: ${amount}.");
            // Assume successful processing
            return $"Transaction successful. ID:" +
                $" {Guid.NewGuid().ToString().Substring(0, 8)}";
        }
    }

    // 3. Proxy (Focusing on Amount Limit Check)
    public class PaymentSecurityProxy : IPaymentProcessor
    {
        private readonly BankPaymentProcessor _realProcessor;
        private const decimal MaxTransactionLimit = 1000m;

        public PaymentSecurityProxy(BankPaymentProcessor realProcessor)
        {
            _realProcessor = realProcessor;
        }

        public string ProcessPayment(string accountId, decimal amount)
        {
            // 🔒 Pre-Processing/Limit Check (The Proxy's Role)
            if (amount > MaxTransactionLimit)
            {
                // Proxy intercepts and handles the request directly (no delegation)
                return $"Payment failed for account: {accountId},  Amount LYD{amount} exceeds transaction limit of LYD{MaxTransactionLimit}.";
            }

            // 🔑 Delegation to the Real Subject
            Console.WriteLine("[PROXY] Amount check passed. Delegating to bank processor.");
            return _realProcessor.ProcessPayment(accountId, amount);
        }
    }
    internal class Program
    {
      

        //The client interacts only with the IPaymentProcessor interface, unaware whether it is talking to the real object or the proxy.
        static void Main(string[] args)
        {
            var realProcessor = new BankPaymentProcessor();
            var securedProcessor = new PaymentSecurityProxy(realProcessor);

            // --- Attempt 1: Too High (Proxy intercepts) ---
            Console.WriteLine("--- Attempt 1: Amount Too High ---");
            string result1 = securedProcessor.ProcessPayment("Ahmed", 1500.00m);
            Console.WriteLine($"Result: {result1}\n");

            // --- Attempt 2: Successful (Proxy delegates) ---
            Console.WriteLine("--- Attempt 2: Successful Payment ---");
            string result2 = securedProcessor.ProcessPayment("Ali", 450.00m);
            Console.WriteLine($"Result: {result2}\n");
        }
    }
}
