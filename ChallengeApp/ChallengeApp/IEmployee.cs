namespace ChallengeApp
{
    //co?

   public interface IEmployee
    {
        string Name { get;}
        string Surname { get;}
        string Sex { get; }
        int Age { get;}

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
