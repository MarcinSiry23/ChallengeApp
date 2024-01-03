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
            employee.AddGrade('b');
            employee.AddGrade('B');
            employee.AddGrade("10");
            employee.AddGrade("asdas");
            employee.AddGrade(20);


            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(10, statistics.Min);
            Assert.AreEqual(47.5, statistics.Average);
            Assert.AreEqual('C', statistics.AverageLetter);
        }

    }
}
