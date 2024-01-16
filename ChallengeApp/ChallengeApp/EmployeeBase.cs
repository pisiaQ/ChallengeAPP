namespace ChallengeApp
{

    public abstract class EmployeBase : IEmployee
    {

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public EmployeBase(string name, string surname)
        {

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract Statistics GetStatistics();
        public abstract void AddGrade(string grade);
        
    }
}