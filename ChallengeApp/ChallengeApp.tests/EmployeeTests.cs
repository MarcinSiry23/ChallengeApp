using System.Reflection.Metadata;

namespace ChallengeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddTwoScoresReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Marcin", "Nowak", 27);
            employee.AddScore(7);
            employee.AddScore(3);

            // act
            var result = employee.Result;
            
            // assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void WhenEmployeeGetNegativeScoreReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Marcin", "Nowak", 27);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(-10);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(0, result);
        }

    }
}
