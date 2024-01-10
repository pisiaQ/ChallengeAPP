namespace ChallengeApp
{
    public class Employee
    {
        public List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(char grade)
        {
            if(float.TryParse(grade.ToString(), out float valueInFloat))
            {
                this.AddGrade(valueInFloat);
            }
            else
            {
                Console.WriteLine($"value has a sign: {grade}");
            }
        }

        public void AddGrade(double grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }

        public void AddGrade(long grade)
        {
            float valueInLong = (float)grade;
            this.AddGrade(valueInLong);
        }
        public void AddGrade(decimal grade)
        {
            float valueInLong = (float)grade;
            this.AddGrade(valueInLong);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Max = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Max(statistics.Min, grade);
                statistics.Average += grade;
            }
            
            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
