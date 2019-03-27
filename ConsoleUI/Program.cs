using OcpLibrary;
using OcpLibrary.Models;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
            public static void Main(string[] args)
            {
                var applicants = new List<PersonModel>()
                {
                    new PersonModel { FirstName="Joe", LastName="Doe" },
                    new PersonModel { FirstName="Mary", LastName="Cool", TypeOfEmployee = EmployeeType.Manager},
                    new PersonModel { FirstName="Davi", LastName="Steph" }
                };

                var employees = new List<EmployeeModel>();
                var accountProcessor = new Accounts();

                foreach (var person in applicants)
                {
                    employees.Add(accountProcessor.Create(person));
                }

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} IsManager: { employee.IsManager } IsExecutive: { employee.IsExecutive }");
                }

                Console.ReadLine();
        }
    }
}
