using System;
using System.Collections.Generic;

public class Student
{
   // Properties
   public string Name { get; set; }
   public List<double> Grades { get; set; }

   // Constructor to initialize the student with a name and an empty list of grades
   public Student(string name)
   {
      Name = name;
      Grades = new List<double>();
   }

   // Method to allow one student to talk to another
   public void TalkTo(Student otherStudent)
   {
      Console.WriteLine($"{Name} is talking to {otherStudent.Name}");
   }

   // Method to allow one student to shout at another
   public void ShoutAt(Student otherStudent)
   {
      Console.WriteLine($"{Name} is shouting at {otherStudent.Name}!");
   }
}

class Program
{
   static void Main(string[] args)
   {
      // Create some students
      Student alice = new Student("Alice");
      Student bob = new Student("Bob");

      // Adding some grades to Alice and Bob
      alice.Grades.Add(92.5);
      alice.Grades.Add(88.0);
      bob.Grades.Add(85.0);
      bob.Grades.Add(90.5);

      // Students interacting
      alice.TalkTo(bob);
      bob.ShoutAt(alice);
   }
}
