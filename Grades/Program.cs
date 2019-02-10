using System;

namespace Grades
{
  class Program
  {
    static void Main(string[] args)
    {
      GradeBook book = new GradeBook();
      book.NameChanged += OnNameChanged;

      book.Name = "Courtney's Grade Book";
      book.Name = "Grade Book";

      book.AddGrade(91);
      book.AddGrade(89.5f);
      book.AddGrade(75);

      GradeStatistics stats = book.ComputeStatistics();

      System.Console.WriteLine(stats.AverageGrade);
      System.Console.WriteLine(stats.HighestGrade);
      System.Console.WriteLine(stats.LowestGrade);
    }
    static void OnNameChanged(object sender, NameChangedEventArgs args)
    {
      Console.WriteLine($"Gradebook changing name from {args.ExistingName} to {args.NewName}");
    }
  }
}
