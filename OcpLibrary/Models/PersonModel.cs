using OcpLibrary.Interfaces;

namespace OcpLibrary.Models
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts.Accounts();

    }
}