namespace AbstractFactoryPattern
{
    public class HighSchoolFactory : ISchoolFactory
    {
        public IStudent CreateStudent()
        {
            return new HighSchoolStudent();
        }

        public ITeacher CreateTeacher()
        {
            return new HighSchoolTeacher();
        }
    }
}
