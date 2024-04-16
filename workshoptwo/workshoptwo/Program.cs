using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
   public string Name { get; set; }
   public List<double> Grades { get; set; }

   public Student(string name)
   {
      Name = name;
      Grades = new List<double>();
   }

   public void TalkTo(Student otherStudent)
   {
      Console.WriteLine($"{Name} is talking to {otherStudent.Name}");
   }

   public void ShoutAt(Student otherStudent)
   {
      Console.WriteLine($"{Name} is shouting at {otherStudent.Name}!");
   }
}

public class Campus
{
   public Student[] Students { get; set; }

   public Campus(Student[] students)
   {
      Students = students;
   }

   public void DisplayStudents()
   {
      foreach (Student student in Students)
      {
         Console.WriteLine($"{student.Name}");
         Console.WriteLine("----------------------------");
      }
   }

   public double CalculateGlobalAverage()
   {
      if (Students.Length == 0) return 0;

      double totalSum = 0;
      int totalGradesCount = 0;

      foreach (Student student in Students)
      {
         if (student.Grades.Count > 0)
         {
            totalSum += student.Grades.Average();
            totalGradesCount++;
         }
      }

      return totalGradesCount > 0 ? totalSum / totalGradesCount : 0;
   }
}

class Program
{
   static void Main(string[] args)
   {
      Student alice = new Student("Alice");
      alice.Grades.Add(92.5);
      alice.Grades.Add(88.0);

      Student bob = new Student("Bob");
      bob.Grades.Add(85.0);
      bob.Grades.Add(90.5);

      Student charlie = new Student("Charlie");
      charlie.Grades.Add(75.0);
      charlie.Grades.Add(82.0);

      Campus myCampus = new Campus(new Student[] { alice, bob, charlie });
      myCampus.DisplayStudents();
      double average = myCampus.CalculateGlobalAverage();
      Console.WriteLine($"The global average grade is: {average:F2}");
   }
}
