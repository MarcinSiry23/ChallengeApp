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
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average,2));
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
            Assert.AreEqual(2, statistics.Average);
        }

    }
}
