using System;

namespace ListEmployees
{
    class Program
    {
        static void Main()
        {
            Employees newEmployee = new Employees(){
                FirstName = "Jim",
                LastName = "Halpert",
                Title = "Sales Representative",
                StartDate = new DateTime(2011, 6, 10)
            };

            Employees newEmployee1 = new Employees(){
                FirstName = "Pam",
                LastName = "Beesly",
                Title = "Secretary",
                StartDate = new DateTime(2010, 6, 10)
            };

            Employees newEmployee2 = new Employees(){
                FirstName = "Andy",
                LastName = "Bernard",
                Title = "Sales Associate",
                StartDate = new DateTime(2013, 6, 10)
            };

            Company newCompany1 = new Company(dateCreated: new DateTime(2006, 5, 26), name: "Dunder-Mifflin");
            newCompany1.employees.Add(newEmployee1);
            newCompany1.employees.Add(newEmployee2);
            newCompany1.employees.Add(newEmployee);

            newCompany1.ListEmployed();
            newCompany1.CompanyInfo();

        }
    }
}
