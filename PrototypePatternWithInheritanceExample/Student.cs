using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternWithInheritanceExample
{
    public  class Student:Person
    {
        public float GPA { get; set; }
        public override Person Clone()
        {
            // Perform a shallow copy
            return new Student
            {
                Name = this.Name,
                GPA = this.GPA
            };
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, GPA: {GPA}");
        }
    }
}
