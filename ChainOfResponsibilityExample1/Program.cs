using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample1
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(int level);
    }

    public class Level1Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Level One Support: Issue resolved.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
    public class Level2Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Level Two Support: Issue resolved.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }

    public class Manager : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Manager: Issue resolved.");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("No one can handle this request");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Setting up the chain of responsibility
            SupportHandler level1 = new Level1Support();
            SupportHandler level2 = new Level2Support();
            SupportHandler manager = new Manager();
            level1.SetNextHandler(level2);
            level2.SetNextHandler(manager);
            // Simulating support requests
            Console.WriteLine("Requesting Level 1 Support:");
            level1.HandleRequest(1);    // Handled by level 1
            Console.WriteLine("\nRequesting Level 2 Support:");
            level1.HandleRequest(2); // Escalates to level 2
            Console.WriteLine("\nRequesting Manager Support:");
            level1.HandleRequest(3); // Escalates to manager
            Console.WriteLine("\nRequesting Unknown Level Support:");
            level1.HandleRequest(4); // No one can handle this request
        }
    }
}
