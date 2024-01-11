namespace ChallengeApp.Tests
{
    public class AddGradeAsLetterTest
    {
        [Test]
        public void CheckStatisticsMinValue()
        {
            Employee employee = new Employee();
            employee.AddGrade(33);
            employee.AddGrade(99);
            employee.AddGrade(1);
            employee.AddGrade(71);
            var statistics = employee.GetStatistics();


            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void CheckStatisticsMaxValue()
        {
            Employee employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(100);
            employee.AddGrade(32);
            employee.AddGrade(91);
            var statistics = employee.GetStatistics();


            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void CheckStatisticsAverage()
        {
            Employee employee = new Employee();
            employee.AddGrade(18);
            employee.AddGrade(54);
            employee.AddGrade(20);
            employee.AddGrade(47);
            var statistics = employee.GetStatistics();


            Assert.AreEqual(Math.Round(34.75, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void CheckStatisticsAverageAsLetter()
        {
            Employee employee = new Employee();
            employee.AddGrade(70);
            employee.AddGrade(100);
            employee.AddGrade(13);
            employee.AddGrade(99);
            var statistics = employee.GetStatistics();


            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}
    