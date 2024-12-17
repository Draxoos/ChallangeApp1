

namespace ChallangeApp1
{
    public abstract class Person
    {
       public Person (string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public String Name { get; private set; }

        public String Surname { get; private set; }
    }
}
