namespace ChallengeApp.Tests
{
    public class StatisticsTest
    {
        private Employee GetEmployee(string Name, string Surname)
        {
            return new Employee(Name, Surname);
        }

        [Test]
        public void CheckingStatistics()
        {
            var employee3 = GetEmployee("Maksymilian", "Puzon");
            employee3.AddGrade(6);
            employee3.AddGrade(8);
            employee3.AddGrade(7);
            var statistics = employee3.GetStatistics();

            Assert.AreNotEqual(3, statistics.Min);
            Assert.AreNotEqual(14, statistics.Max);
            Assert.AreNotEqual(5, statistics.Average);
        }
    }
}
