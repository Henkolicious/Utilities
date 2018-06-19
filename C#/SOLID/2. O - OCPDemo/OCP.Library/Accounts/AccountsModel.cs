using OCP.Library.Acconts.Interfaces;
using OCP.Library.Applicants.Interfaces;

namespace OCP.Library.Acconts
{
    public class AccountsModel : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAdress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@xxx.com"
            };

            return output;
        }
    }
}
