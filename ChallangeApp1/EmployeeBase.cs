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
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(decimal grade)
        {
            float gradefromdecimal = (float)grade;
            this.AddGrade(gradefromdecimal);
        }


        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception("Błąd rzutowania zmiennej");
            }
        }


        public abstract Statistics GetStatistics();
        
    }
}
