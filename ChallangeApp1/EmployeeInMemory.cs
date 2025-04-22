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

                foreach (var grade in this.grade)
                {
                    statistics.AddGrade(grade);
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
