
using System.Diagnostics.Metrics;

namespace ChallangeApp1
{
    public class EmployeeInFile : EmployeeBase
    {
       
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades.txt";
        private List<float> grade = new List<float>();
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }

        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                var counter = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var singleValue = float.Parse(line);
                        result.AddGrade(grade);
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("plik nie istnieje");
            }

            var statistics = new Statistics();

            foreach (var grade in this.grade)
            {
                statistics.AddGrade(grade);
            }

            if (statistics.Count > 0)
            {
                return statistics;
            }
            else
            {
                throw new Exception("Wybrany pracownik nie posiada żadnych ocen");
            }
        }
    }   
}
