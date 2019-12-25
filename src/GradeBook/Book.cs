using System;
using System.Collections.Generic;

namespace GradeBook
{   
    public class Book 
    {
        List<double> grades;
        public string Name;
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade){
            grades.Add(grade);
        }

        public Statistics GetStatistics(){

            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach(var grade in grades){
                result.Average += grade;
                result.Low = Math.Min(result.Low, grade);
                result.High = Math.Max(result.High, grade);
            }
            result.Average /= grades.Count;

            return result;

        }
    } 
}
