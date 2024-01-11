using System.Diagnostics;

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

             public Statistics GetStatisticsWithForEach()
        {
          var statistics = new Statistics();
          statistics.Average = 0;
          statistics.Max = float.MinValue;
          statistics.Min = float.MaxValue;

          foreach (var grade in this.grades)
          {
              statistics.Max = Math.Max(statistics.Max, grade);
              statistics.Min = Math.Min(statistics.Min, grade);
              statistics.Average += grade;
          }
          statistics.Average /= this.grades.Count;


          return statistics;

         }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;

            var index = 0;

            var number = this.grades[index];
            while (index < this.grades.Count)
            {
                number = this.grades[index];
                statistics4.Max = Math.Max(statistics4.Max, number);
                statistics4.Min = Math.Min(statistics4.Min, number);
                statistics4.Average += number;
                index++;
            }
            statistics4.Average /= this.grades.Count;


            return statistics4;

        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            var index = 0;

            do
            {
                var number = this.grades[index];
                statistics3.Max = Math.Max(statistics3.Max, number);
                statistics3.Min = Math.Min(statistics3.Min, number);
                statistics3.Average += number;
                index++;
            }
            while (index < this.grades.Count);

            statistics3.Average /= this.grades.Count;

            return statistics3;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            float number = 0;
            for (int index = 0; index < this.grades.Count; ++index)
            {
                number = this.grades[index];
                statistics2.Max = Math.Max(statistics2.Max, number);
                statistics2.Min = Math.Min(statistics2.Min, number);
                statistics2.Average += number;
            }
            statistics2.Average /= this.grades.Count;


            return statistics2;

        }
        public Statistics GetStatistics()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade;
            }
            statistics1.Average /= this.grades.Count;


            return statistics1;

        }
    }
}
