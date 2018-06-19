using OCP.Library.Acconts.Interfaces;

namespace OCP.Library.Applicants.Interfaces
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountProcessor { get; set; }
    }
}