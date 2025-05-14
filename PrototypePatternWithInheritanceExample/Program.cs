using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternWithInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student original = new Student
            {
                Name = "Ali",
                GPA = 88.5f
            };

            // Clone the student
            Student copy = (Student)original.Clone();
            copy.Name = "Salem"; // Change name to show difference
            original.Display(); // Output: Name: Ali, Grade: 10
            copy.Display();  // Output: Name: Salem, Grade: 10
        }
    }
}
