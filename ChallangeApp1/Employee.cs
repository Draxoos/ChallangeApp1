namespace ChallangeApp1
{
    public abstract class Employee : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        event EmployeeBase.GradeAddedDelegate IEmployee.GradeAdded
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        private List<float> grades = new List<float>();

        public Employee()
        {
        }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public Employee(string name)
            : this(name, "no surname") { }
        public void AddGrade(float grade)
        {
            int valueinint = (int)grade;
            float f = valueinint;

            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid data provided");
            }
        }

        public void AddGrade(int grade)
        {
            float gradeasfloat = grade;
            AddGrade(gradeasfloat);
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

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            float result = grade;
            AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            AddGrade(result);
        }
        public abstract Statistics GetStatistics();
    }
}