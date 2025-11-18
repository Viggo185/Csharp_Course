using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uppgift_24_ClassFields_exercise_in_C_
{
    internal class Program
    {
        class Person
        {
            private string FirstName;
            private string LastName;
            private int Age;
            private int BirthYear;
            private string Nationality;

            public Person (string firstName, string lastName, int age, int birthYear, string nationality)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                BirthYear = birthYear;
                Nationality = nationality;
            }

            public void SetfirtsName(string firstName)
            {
                this.FirstName = !string.IsNullOrEmpty(firstName) ? firstName : "Invalid name!";
            }
            public string GetfirstName()
            {
                return FirstName;
            }

            public void SetlastName(string lastName)
            {
                this.LastName = !string.IsNullOrEmpty(lastName) ? lastName : "Invalid name!";
            }
            public string GetlastName()
            { 
                return LastName; 
            }

            public void SetAge(int age)
            {
                this.Age = age >= 0 && age <= 150 ? age : -1;
            }
            public int GetAge()
            {
                return Age;
            }
             
            public void SetBirthYear(int birthYear)
            {
                this.BirthYear = birthYear <= 2025 ? birthYear : -1;
            }
            public int GetBirthYear()
            {
                return BirthYear;
            }

            public void SetNationality(string nationality)
            { 
                this.Nationality = !string.IsNullOrEmpty(nationality) ? nationality : "Invalid nationality!";
            }
            public string GetNationality()
            {
                return Nationality;
            }

            public string ReturnDetails()
            {
                return $"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}\nBirth Year: {BirthYear}\nNationality: {Nationality}";
            }



        }
        static void Main(string[] args)
        {
            Person person = new Person("Alex", "Carter", 21, 2004, "Canadian");

            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine();

            person.SetfirtsName("Tim");
            person.SetlastName("Rivera");
            person.SetAge(30);
            person.SetBirthYear(1995);
            person.SetNationality("American");
            Console.WriteLine(person.ReturnDetails());
        }
    }
}
