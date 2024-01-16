namespace ChallengeApp
{
    public class EmployeeInFile : EmployeBase
    {

        private const string fileName = "grades.txt";

        public event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname)
             : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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
            AddGrade(gradeAsfloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsfloat = (float)grade;
            AddGrade(gradeAsfloat);
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
                AddGrade(result);
            }
            else if (char.TryParse(grade, out char charGrade))
            {
                throw new Exception("String in not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromfile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromfile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        public Statistics CountStatistics(List<float> grades)
        {
            {
                var statistics = new Statistics();

                foreach (var grade in grades)
                {
                    statistics.AddGrade(grade);
                }

                return statistics;
            }
        }
    }
}