using OCP.Library;
using OCP.Library.Applicants;
using OCP.Library.Applicants.Interfaces;
using System;
using System.Collections.Generic;

namespace OCPDemo
{
    public class Program
    {

        // Simple example of S[O]LID:s Open / Closed Principle.
        // - Open for extentions
        // - Closed for modification
        public static void Main(string[] args)
        {
            List<IApplicantModel> applicants = GetApplicants();
            List<EmployeeModel> employees = CreateEmployeesFromApplicants(applicants);
            PrintEmployees(employees);
            Console.ReadKey();
        }

        private static List<IApplicantModel> GetApplicants()
        {
            return new List<IApplicantModel>
            {
                new PersonModel { FirstName ="John", LastName = "Doe"},
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new ExecutiveModel {  FirstName = "Bruce", LastName ="Roman"}
            };
        }

        private static List<EmployeeModel> CreateEmployeesFromApplicants(List<IApplicantModel> applicants)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }
            return employees;
        }

        private static void PrintEmployees(List<EmployeeModel> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAdress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }
        }
    }
}
