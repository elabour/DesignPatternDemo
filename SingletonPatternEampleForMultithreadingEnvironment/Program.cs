using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExampleForMultithreadingEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;
            if (s1 == s2)
            {
                Console.WriteLine("Both instances are the same.");
            }
            else
            {
                Console.WriteLine("Instances are different.");
            }
        }
    }
}
