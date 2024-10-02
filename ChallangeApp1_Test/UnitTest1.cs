using ChallengeApp1;
using System.Reflection.Metadata;

namespace ChallangeApp1_Test
{
    public class TypeTests
    {
       

        [Test]
        public void NumbersAreEqual()
        {
            //arrange
            int number1 = 5;
            int number2 = 5;

            //act


            //assert
           Assert.AreEqual(number1, number2);

        }


        [Test]
        public void EmployeesNotEqual()
        {
            //arrange
            var employee1 = GetEmployee("Eryk");
            var employee2 = GetEmployee("Eryk");
            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
       
       
        [Test]

        public void StringsAreEqual()
        {
            //arrange
            string a = "69";
            string b = "69";
            //act


            //assert
            Assert.AreEqual(a, b);
        }

        [Test]

        public void DoubleAreNotEqual()
        {
            //arrange
            double a = 3.14159265358919328462643383279;
            double b = 3.14159265358979328462643383279;
            //act


            //assert
            Assert.AreNotEqual(a, b);
        }

        [Test]

        public void FloatAreNotEqual()
        {
            //arrange
            float number1 = 342423;
            float number2 = 346423;
            //act


            //assert
            Assert.AreNotEqual(number1,number2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}