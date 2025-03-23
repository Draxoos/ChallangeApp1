namespace ChallangeApp1
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name {  get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);


        public void AddGrade(int grade)
        {
            float gradefromintiger = (float)grade;
            this.AddGrade(gradefromintiger);
        }


        public void AddGrade(double grade)
        {
            float gradefromdouble = (float)grade;
            this.AddGrade(gradefromdouble);
        }


        public void AddGrade(char grade)
        {
            float gradefromchar = (float)grade;
            this.AddGrade(gradefromchar);
        }


        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Błąd rzutowania zmiennej");
            }
        }


        public abstract Statistics GetStatistics();
        
    }
}
