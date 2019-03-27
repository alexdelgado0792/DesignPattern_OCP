using OcpLibrary.Interfaces;

namespace OcpLibrary.Models
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public IAccounts AccountProcessor { get ; set; } = new ManagerAccounts();
    }
}
