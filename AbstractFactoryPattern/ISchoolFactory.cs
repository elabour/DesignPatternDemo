namespace AbstractFactoryPattern
{
    public interface ISchoolFactory
    {
        IStudent CreateStudent();
        ITeacher CreateTeacher();
    }
}
