using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Outmane Baladi book");
            book.AddGrade(52.6);
            book.AddGrade(20.2);
            book.AddGrade(15.3);

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is: {stats.Average:N1}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The highest grade is: {stats.High}");
        }
    }
}
