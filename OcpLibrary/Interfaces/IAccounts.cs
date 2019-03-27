using OcpLibrary.Models;

namespace OcpLibrary.Interfaces
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}