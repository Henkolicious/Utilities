using OCP.Library.Acconts;
using OCP.Library.Acconts.Interfaces;
using OCP.Library.Applicants.Interfaces;

namespace OCP.Library.Applicants
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set ; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccountsModel();
    }
}
