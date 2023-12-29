namespace ChallengeApp.tests
{
    public class TypeTest
    {
        [Test]
        public void TestReferenceType()
        {
            // arrange
            var employee1 = GetEmployee("Marcin", "Nowak");
            var employee2 = GetEmployee("Marcin", "Kowalski");

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);

        }

        [Test]
        public void TestString()
        {
            // arrange
            var employee1 = GetEmployee("Marcin", "Nowak");
            var employee2 = GetEmployee("Marcin", "Kowalski");

            // act

            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);

        }

        [Test]
        public void TestInt()
        {
            // arrange
            int age1 = 10;
            int age2 = 10;   

            // act

            // assert
            Assert.AreEqual(age1, age2);

        }

        [Test]
        public void TestDifferentTypes()
        {
            // arrange
            double score1 = 10.7;
            int score2 = 10;

            // act

            // assert
            Assert.AreEqual(20.7, score1 + score2);

        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
