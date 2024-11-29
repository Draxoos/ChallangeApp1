using ChallengeApp1;
using System.Reflection.Metadata;

namespace ChallangeApp1_Test
{
    public class EmployeeGradeTests
    {

        [Test]
        public void CheckScore()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade(50);
            employee.AddGrade(60);
            employee.AddGrade(404);

            //act
            var stats_01 = employee.GetStatistics();
            //assert
            Assert.AreEqual(stats_01.Min, 50);
            Assert.AreEqual(stats_01.Max,60);
            Assert.AreEqual(stats_01.Average, 55);
        }

        [Test]
        public void CheckMixedScore()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade("50");
            employee.AddGrade(60);
            employee.AddGrade("d");

            //act
            var stats_02 = employee.GetStatistics();

            //assert
            Assert.AreEqual(stats_02.Min, 50);
            Assert.AreEqual(stats_02.Max, 60);
            Assert.AreEqual(stats_02.Average, 55);
        }

       
    }
}