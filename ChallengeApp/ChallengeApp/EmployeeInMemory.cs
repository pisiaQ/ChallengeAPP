namespace ChallengeApp
{

    public class EmployeeinMemory : EmployeBase
    {
        public delegate string WriteMessage(string message);

        public event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeinMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsfloat = (float)grade;
            this.AddGrade(gradeAsfloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsfloat = (float)grade;
            this.AddGrade(gradeAsfloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charGrade))
            {
                throw new Exception("String in not float");
            }
        }
        public override Statistics GetStatistics()
        {
            {
                var statistics = new Statistics();

                foreach (var grade in this.grades)
                {
                    statistics.AddGrade(grade);
                }

                return statistics;
            }
        }
    }
}