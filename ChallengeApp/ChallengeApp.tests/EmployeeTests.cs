using System.Reflection.Metadata;

namespace ChallengeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeGetGradesReturnCorrectStatistic()
        {
            // arrange
            var employee = new Employee("Marcin", "Nowak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(3.33333325f, statistics.Average);
        }

        [Test]
        public void WhenEmployeeGetNegativeGradesReturnCorrectStatistic()
        {
            // arrange
            var employee = new Employee("Marcin", "Nowak");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(-2);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Max);
            Assert.AreEqual(-2, statistics.Min);
            Assert.AreEqual(3na, statistics.Average);
        }

    }
}
