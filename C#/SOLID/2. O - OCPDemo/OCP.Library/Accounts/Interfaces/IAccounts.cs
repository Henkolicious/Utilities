using OCP.Library.Applicants.Interfaces;

namespace OCP.Library.Acconts.Interfaces
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}