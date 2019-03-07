using System;
using System.Collections.Generic;

namespace ListEmployees
{
    public class Employees
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate {get; set;}
    }


    public class Company
    {
        public Company(string name, DateTime dateCreated){
            Name = name;
            CreatedOn = dateCreated;
            employees = new List<Employees>();
        }
        public DateTime CreatedOn  {get;}
        public string Name { get; }

        public List<Employees> employees {get; set;}

        public void ListEmployed(){
            foreach (Employees Employed in employees)
            {
                Console.WriteLine( $"{Employed.FirstName} {Employed.LastName} is a {Employed.Title} who works at {Name}. He/She started working at {Name} on {Employed.StartDate}.");
                Console.WriteLine($"{Name} was founded on {CreatedOn}");
            }
         }
    }
}