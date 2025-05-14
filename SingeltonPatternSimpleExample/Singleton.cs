using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternSimpleExample
{
    public class Singleton
    {
        private static Singleton _instance;
        // Private constructor to
        // prevent instantiation
        private Singleton()
        {
          
        }
         //Public method to get
         //the instance of the singleton
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
