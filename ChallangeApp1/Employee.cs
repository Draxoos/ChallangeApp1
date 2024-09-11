namespace ChallengeApp1
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string last_name, int age, int result)
        {
            this.Name = name;
            this.Last_Name = last_name;
            this.Age = age;
        }


        public string Name { get; private set; }
        public string Last_Name { get; private set; }
        public int Age { get; private set; }


        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }



}