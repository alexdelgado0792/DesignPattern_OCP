using OcpLibrary.Interfaces;
using OcpLibrary.Models;

namespace OcpLibrary.Accounts
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@domain.com";
            
            return output;
        }

    }
}