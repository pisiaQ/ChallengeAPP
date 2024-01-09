namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void VarTypeTest()
        {
            // arrange
            var employee1 = new User("Maciej", "Juzek", 21);
            var employee2 = new User("Maciej", "Juzek", 21);

            // assert
            Assert.AreNotEqual(employee1, employee2);
            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void IntTypeTest()
        {
            // arrange
            int number1 = 1;
            int number2 = 7;

            // assert
            Assert.AreEqual(number1 + number2, 8);
        }

        [Test]
        public void FloatTypeTest()
        {
            // arrange
            float lenght1 = 3.3F;
            float lenght2 = 1.1F;
            float lenght3 = 4.4F;

            // assert
            Assert.AreEqual(lenght1 + lenght2, lenght3);
        }

        [Test]
        public void StringTypeTest()
        {
            // arrange
            string name1 = "Eugenia";
            string name2 = "Eugenia";

            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void DoubleTypeTest()
        {
            // arrange
            double number1 = 1.11;
            double number2 = 2.22;

            // assert
            Assert.AreEqual(number1 + number2, 3.33);
        }
    }
}