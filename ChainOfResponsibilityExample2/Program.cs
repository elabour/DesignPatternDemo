using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample2
{
    public abstract class Dispenser
    {
        protected Dispenser nextDispenser;

        public void SetNext(Dispenser next)
        {
            nextDispenser = next;
        }

        public abstract void Dispense(int amount);
    }

    public class Dinnars50Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount >= 50)
            {
                int count = amount / 50;
                Console.WriteLine("Dispensing " + count + " 50$ note(s)");
                amount %= 50;
            }
            if (nextDispenser != null)
            {
                nextDispenser.Dispense(amount);
            }
        }
    }
    public class Dinnars20Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount >= 20)
            {
                int count = amount / 20; 
                Console.WriteLine("Dispensing " + count + " 20$ note(s)");
                amount %= 20; 
            }
            if (nextDispenser != null)
            {
                nextDispenser.Dispense(amount);
            }
        }
    }
    public class Dinnars10Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount >= 10)
            {
                int count = amount / 10;
                Console.WriteLine("Dispensing " + count + " 10$ note(s)");
                amount %= 10;
            }
            if (nextDispenser != null)
            {
                nextDispenser.Dispense(amount);
            }
        }
    }
    public class Dinnars5Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount >= 5)
            {
                int count = amount / 5;
                Console.WriteLine("Dispensing " + count + " 5$ note(s)");
                amount %= 5;
            }
            if (nextDispenser != null)
            {
                nextDispenser.Dispense(amount);
            }
        }
    }

    public class dinar1Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount >= 1)
            {
                int count = amount / 1;
                Console.WriteLine("Dispensing " + count + " 1$ note(s)");
                amount %= 1;
            }
            if (nextDispenser != null)
            {
                nextDispenser.Dispense(amount);
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Dispenser d50 = new Dinnars50Dispenser();
            Dispenser d20 = new Dinnars20Dispenser();
            Dispenser d10 = new Dinnars10Dispenser();
            Dispenser d5 = new Dinnars5Dispenser();
            Dispenser d1 = new dinar1Dispenser();
            d50.SetNext(d20);
            d20.SetNext(d10);
            d10.SetNext(d5);
            d5.SetNext(d1);
            int amount = 17; // Example amount
            Console.WriteLine("Dispensing amount: " + amount);
            d50.Dispense(amount);
            Console.ReadLine();
        }
    }
}
