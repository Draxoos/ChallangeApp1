namespace ChallangeApp1
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor()
        {
        }
        public Supervisor(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }
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

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong Grade");
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
             Statistics GetStatistics()
            {
                var statistics = new Statistics();
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

                statistics.Average /= grades.Count;

                return statistics;
            }

             Statistics GetStatisticsWithFor()
            {
                var statistics = GetStatistics();

                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                for (int i = 0; i < grades.Count; i++)
                {
                    statistics.Max = Math.Max(statistics.Max, grades[i]);
                    statistics.Min = Math.Min(statistics.Min, grades[i]);
                    statistics.Average += grades[i];
                }
                statistics.Average /= grades.Count;
                return statistics;
            }

             Statistics GetStatisticsWithWhile()
            {
                var statistics = GetStatistics();

                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                var index = 0;

                while (index < grades.Count)
                {
                    statistics.Max = Math.Max(statistics.Max, grades[index]);
                    statistics.Min = Math.Min(statistics.Min, grades[index]);
                    statistics.Average += grades[index];
                    index++;
                }
                statistics.Average /= grades.Count;
                return statistics;
            }

             Statistics GetStatisticsWithDoWhile()
            {
                var statistics = GetStatistics();

                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                var index = 0;

                do
                {
                    statistics.Max = Math.Max(statistics.Max, grades[index]);
                    statistics.Min = Math.Min(statistics.Min, grades[index]);
                    statistics.Average += grades[index];
                    index++;
                } while (index < grades.Count);
                statistics.Average /= grades.Count;
                return statistics;
            }
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}