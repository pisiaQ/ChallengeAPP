
namespace ChallengeApp
{
    public abstract class Person // : System.Object
    {
        public Person(string name, string surname, string sex) 
        {
            this.Surname = surname;
            this.Name = name;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }

    }
}
