using OcpLibrary;
using OcpLibrary.Models;
using System;
using System.Collections.Generic;
using OcpLibrary.Interfaces;

namespace ConsoleUI
{
    public class Program
    {
            public static void Main(string[] args)
            {
                IList<IApplicantModel> applicants = new List<IApplicantModel>()
                {
                    new PersonModel { FirstName="Joe", LastName="Doe" },
                    new ManagerModel { FirstName="Mary", LastName="Cool"},
                    new ExecutiveModel() { FirstName="Davi", LastName="Steph"}
                };

                var employees = new List<EmployeeModel>();
                var accountProcessor = new Accounts();

                foreach (var person in applicants)
                {
                    employees.Add(person.AccountProcessor.Create(person));
                }

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} IsManager: { employee.IsManager } IsExecutive: { employee.IsExecutive }");
                }

                Console.ReadLine();
        }
    }
}
