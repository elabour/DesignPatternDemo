using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISchoolFactory highSchoolFactory = new HighSchoolFactory();
            IStudent highSchoolStudent = highSchoolFactory.CreateStudent();
            ITeacher highSchoolTeacher = highSchoolFactory.CreateTeacher();

            Console.WriteLine("High School:");
            Console.WriteLine(highSchoolStudent.GetDetails());
            Console.WriteLine(highSchoolTeacher.GetDetails());

            Console.WriteLine();

            ISchoolFactory collegeFactory = new CollegeFactory();
            IStudent collegeStudent = collegeFactory.CreateStudent();
            ITeacher collegeTeacher = collegeFactory.CreateTeacher();

            Console.WriteLine("College:");
            Console.WriteLine(collegeStudent.GetDetails());
            Console.WriteLine(collegeTeacher.GetDetails());

            Console.ReadKey();
        }
    }
}
