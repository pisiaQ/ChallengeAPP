namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase // : IEmployee
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, string sex, int age)
            : base(name, surname, sex, age)
        {

        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((int)grade);
        }

        public override void AddGrade(float grade)
        {
            this.AddGrade((int)grade);
        }

        public override void AddGrade(int grade)
        {
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
                    throw new Exception("Invailid grade Value.");
                }
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                if (grade.Length == 1)
                {
                    AddGrade(grade[0]);

                }
                else
                {
                    throw new Exception("Invalid Grade");
                }
            }
        }


        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    AddGrade(100.0f);
                    break;
                case 'B' or 'b':
                    AddGrade(80.0f);
                    break;
                case 'C' or 'c':
                    AddGrade(60.0f);
                    break;
                case 'D' or 'd':
                    AddGrade(40.0f);
                    break;
                case 'E' or 'e':
                    AddGrade(20.0f);
                    break;
                default:
                    throw new Exception("Wrong Letter. Write Letter between A and E or a and e");
            }
        }

        public override Statistics GetStatistics()

        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var Average when Average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var Average when Average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var Average when Average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var Average when Average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}