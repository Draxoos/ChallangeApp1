
namespace ChallangeApp1
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
           if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
           else
            {
                throw new Exception("invalid grade value");
            }

        }

        private List<float> grade = new List<float>();
        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var singleValue = float.Parse(line);
                        grade.Add(singleValue);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("plik nie istnieje");
            }

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

                statistics.Average /= grade.Count;

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        result.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        result.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        result.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        result.AverageLetter = 'D';
                        break;
                    default:
                        result.AverageLetter = 'E';
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