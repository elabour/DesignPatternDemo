using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public  class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
        public Person()
        {
           
        }
        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
