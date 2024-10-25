using ChallengeApp1;
using System.Reflection.Metadata;

namespace ChallangeApp1_Test
{
    public class StatisticsTests
    {

        [Test]
        public void EmployeeCollectPositiveGrade()
        {
            //arrange
            var employee = new Employee("Eryk", "Turliński");
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();

            //act
            var averageresult = statistics.Average;
            var minresult = statistics.Min;
            var maxresult = statistics.Max;

            //assert
            Assert.AreEqual(4.66666651f, averageresult);
            Assert.AreEqual(2, minresult);
            Assert.AreEqual(7, maxresult);
        }

        [Test]
        public void EmployeeCollectNegativeGrade()
        {
            //arrange
            var employee = new Employee("Sara", "Jurczyk");
            employee.AddGrade(-8);
            employee.AddGrade(-3);
            employee.AddGrade(-4);
            var statistics = employee.GetStatistics();

            //act
            var averageresult = statistics.Average;
            var minresult = statistics.Min;
            var maxresult = statistics.Max;

            //assert
            Assert.AreEqual(-5, averageresult);
            Assert.AreEqual(-8, minresult);
            Assert.AreEqual(-3, maxresult);
        }

        [Test]
        public void EmployeeCollectMixedGrade()
        {
            //arrange
            var employee = new Employee("Grzegoż", "Żak");
            employee.AddGrade(-5);
            employee.AddGrade(10);
            employee.AddGrade(-2);
            var statistics = employee.GetStatistics();

            //act
            var averageresult = statistics.Average;
            var minresult = statistics.Min;
            var maxresult = statistics.Max;

            //assert
            Assert.AreEqual(1, averageresult);
            Assert.AreEqual(-5, minresult);
            Assert.AreEqual(10, maxresult);
        }
    }
}