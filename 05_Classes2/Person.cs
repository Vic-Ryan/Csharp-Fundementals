using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes2
{
    public class Person
    {
        //field v
        private string _LastName;
        public Person() { }
        public Person(string firstName, string lastName, DateTime dOB)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dOB;
        }


        public string FirstName { get; set; }
        public string LastName
        {
            get
            {
                return _LastName[0].ToString();
            }
            set
            {
                _LastName = value;
            }
        }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        public Vehicle Transport { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void Brag()
        {
            Console.WriteLine($"I'm {FirstName}, and I own a {Transport.Make} {Transport.Model}, it's a {Transport.VehicleType}.");
        }
    }
}
