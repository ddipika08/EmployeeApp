using EmployeeExtensionApp.Models;

namespace EmployeeExtensionApp.Extensions
{
    public static class EmployeeExtensions
    {
        public static string GetEmployeeInfo(this Employee employee)
        {
            return $"Employee: {employee.Name}, " +
                   $"Department: {employee.Department}, " +
                   $"Salary: ₹{employee.Salary}";
        }
    }
}