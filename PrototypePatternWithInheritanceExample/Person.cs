using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternWithInheritanceExample
{
    public abstract class Person
    {
        public string Name { get; set; }
        public abstract Person Clone(); 
    }
}
