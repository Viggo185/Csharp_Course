using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_17_Dictionary_Case_Task_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>();



            while (true)
            {
                
                Console.WriteLine("======Student Management Menu======");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Display all students and their id numbers");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Chose a option (1-4):");
                int choise = int.Parse(Console.ReadLine());


                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter student ID (number)");
                        string newStudet = Console.ReadLine();
                        Console.WriteLine("Enter student name: ");
                        string newName = Console.ReadLine();
                        subjects.Add(newStudet, newName);
                        Console.WriteLine($"Student {newName} has bean added successfully");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter student ID (number) of the student you want to remove: ");
                        string studentRemover = Console.ReadLine();
                        if (subjects.ContainsKey(studentRemover))
                        {
                            subjects.Remove(studentRemover);
                            Console.WriteLine($"Student {studentRemover} has been removed");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                         Console.WriteLine("======List of students======");
                        foreach(var subject  in subjects)
                        {
                            Console.WriteLine($"ID:{subject.Key} - Name:{subject.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid input! försök igen");
                        break;

                }


            }
        }
    }
}
