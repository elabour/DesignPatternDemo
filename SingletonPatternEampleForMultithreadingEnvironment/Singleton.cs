using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExampleForMultithreadingEnvironment
{
    public sealed class Singleton
    {
        //We are using volatile to ensure that
        //assignment to the instance
        //variable finishes before it’s access.
        private static volatile Singleton instance;
        private static object lockObject = new Object();
        private Singleton() { }
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
    
}
