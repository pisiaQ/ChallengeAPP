﻿namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Łukasz";
        public string Surname => "Pisiak";
        public string Sex => "Men";
        public int Age => (22);

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            return new Statistics();
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    AddGrade(95);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5+":
                case "+5":
                    AddGrade(85);
                    break;
                case "5-":
                case "-5":
                    AddGrade(75);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "4+":
                case "+4":
                    AddGrade(65);
                    break;
                case "4-":
                case "-4":
                    AddGrade(55);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3+":
                case "+3":
                    AddGrade(45);
                    break;
                case "3-":
                case "-3":
                    AddGrade(35);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "2+":
                case "+2":
                    AddGrade(25);
                    break;
                case "2-":
                case "-2":
                    AddGrade(15);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Misspelled rating");

            }

        }

    }
}
