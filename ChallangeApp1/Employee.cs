using ChallangeApp1;
using System.Diagnostics;

namespace ChallengeApp1
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
            :base(name,surname) { }

        public Employee(string name)
            :this(name, "no surname") { }
        public void AddGrade(float grade)
        {
            int valueinint = (int)grade;
            float f = valueinint;

           if(grade >= 0 && grade <= 100)
            {
               this.grades.Add(grade);
            }
           else
            {
                throw new Exception("invalid data provided");
            }
        }

        public void AddGrade(char grade)
        {
           switch(grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
               default:
                    throw new Exception("Wrong Letter"); 
            }
        }

        public void AddGrade(string grade)
        {
         if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public void AddGrade(decimal grade)
        {
         float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = GetStatistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = GetStatistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count) 
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = GetStatistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;
        } 
    }
}