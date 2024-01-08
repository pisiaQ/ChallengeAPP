namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void ChceckSumWhenEmployeeCollctedPossAndNeggScores()
        {
            //arrange
            var user = new Employee("Tymek", "Malesiñski", 20);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(8);
            user.AddScore(-14);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void ChceckSumWhenEmployeeCollctedPossScores()
        {
            //arrange
            var user = new Employee("Dariusz", "B¹k", 20);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(8);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(19, result);
        }

        [Test]
        public void ChceckSumWhenEmployeeCollctedNeggScores()
        {
            //arrange
            var user = new Employee("Zosia", "Samosia", 20);
            user.AddScore(-5);
            user.AddScore(-6);
            user.AddScore(-8);
            user.AddScore(-14);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(-33, result);
        }
    }
}