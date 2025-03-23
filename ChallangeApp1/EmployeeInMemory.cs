namespace ChallangeApp1
{
    public class EmployeeInMemory : EmployeeBase
    {
       
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        private List<float> grade = new List<float>();

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
              this.grade.Add(grade); 
                
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid score value");
            }
        }

       

        public override Statistics GetStatistics()
        {
            if (this.grade.Count > 0)
            {
                var statistics = new Statistics();

                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                statistics.Average = 0;

                foreach (var grade in this.grade)
                {
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Max = Math.Max(statistics.Max, grade);
                }

                statistics.Average = this.grade.Sum() / this.grade.Count;

                switch (statistics.Average)
                {
                    case var x when x >= 80:
                         statistics.AverageLetter = 'A';
                        break;
                    case var x when x >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var x when x >= 40: 
                        statistics.AverageLetter = 'C';
                        break;
                    case var x when x >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                        default:
                        statistics.AverageLetter = 'E';
                        break;

                }
                return statistics;
            }
            else
            {
                return null;
            }
        }
    }
}
