//namespace FirstProject1
//{
//    public class Employee : IEmployee

//    {
//        private List<float> grades = new List<float>();

//        public Employee(string name, string surname)

//        {
//            this.Name = name;
//            this.Surname = surname;
//        }

//        public string Name { get; private set; }
//        public string Surname { get; private set; }

//        public void AddGrade(float grade)
//        {

//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            else
//            {
//                throw new Exception("Invailid grade Value. Add between 0 and 100");
//            }
//        }
//        public void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'A' or 'a':
//                    AddGrade(100.0f);
//                    break;
//                case 'B' or 'b':
//                    AddGrade(80.0f);
//                    break;
//                case 'C' or 'c':
//                    AddGrade(60.0f);
//                    break;
//                case 'D' or 'd':
//                    AddGrade(40.0f);
//                    break;
//                case 'E' or 'e':
//                    AddGrade(20);
//                    break;
//                default:
//                    throw new Exception("Wrong Letter. Write Letter between A and E or a and e");
//            }
//        }

//        public void AddGrade(string grade)
//        {
//            if (float.TryParse(grade, out float result))
//            {
//                this.AddGrade(result);
//            }
//            else
//            {
//                if (grade.Length == 1)
//                {
//                    AddGrade(grade[0]);
//                }
//                else
//                {
//                    throw new Exception("Invalid Grade");
//                }
//            }
//        }

//        public void AddGrade(double grade)
//        {
//         this.AddGrade((float)grade);
//        }

//        public void AddGrade(int grade)
//        {
//            this.AddGrade((float)grade);
//        }

//         public Statistics GetStatistics()

//       {
//            var statistics = new Statistics();
//            statistics.Average = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            foreach (var grade in this.grades)
//            {
//                if (grade >= 0)
//                {
//                    statistics.Max = Math.Max(statistics.Max, grade);
//                    statistics.Min = Math.Min(statistics.Min, grade);
//                    statistics.Average += grade;
//                }
//            }
//            statistics.Average /= this.grades.Count;

//            switch (statistics.Average)
//            {
//                case var Average when Average >= 80:
//                    statistics.AverageLetter = 'A';
//                    break;
//                case var Average when Average >= 60:
//                    statistics.AverageLetter = 'B';
//                    break;
//                case var Average when Average >= 40:
//                    statistics.AverageLetter = 'C';
//                    break;
//                case var Average when Average >= 20:
//                    statistics.AverageLetter = 'D';
//                    break;
//                default:
//                    statistics.AverageLetter = 'E';
//                    break;
//            }
//            return statistics;
//        }
//    }
//}