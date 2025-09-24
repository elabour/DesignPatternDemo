namespace AbstractFactoryPattern
{
    public class CollegeFactory : ISchoolFactory
    {
        public IStudent CreateStudent()
        {
            return new CollegeStudent();
        }

        public ITeacher CreateTeacher()
        {
            return new CollegeTeacher();
        }
    }
}
