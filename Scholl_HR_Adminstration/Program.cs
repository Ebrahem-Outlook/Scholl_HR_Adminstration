using HR_Adminstration_API;
using Scholl_HR_Adminstration.Models;

namespace Scholl_HR_Adminstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);

            Console.WriteLine($"The Salary of Employee is :: {employees.Sum(e => e.Salary)}");
        }

        public static void SeedData(IList<IEmployee> employees)
        {
            IEmployee teacher = Factory.GetEmployee(EmployeeType.Teacher, 1, "Ebrahem", "Mohamed", 100000);
            employees.Add(teacher);

            IEmployee manager = Factory.GetEmployee(EmployeeType.Manager, 2, "Mohamed", "Ahemad", 200000);
            employees.Add(manager);

            IEmployee headManager = Factory.GetEmployee(EmployeeType.HeadManager, 3, "Maraim", "Mohamed", 300000);
            employees.Add(headManager);

            IEmployee ceo = Factory.GetEmployee(EmployeeType.Ceo, 4, "Malak", "Mohamed", 400000);
            employees.Add(ceo);
        }
    }

    public static class Factory
    {
        public static IEmployee employee = null;
        public static IEmployee GetEmployee(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            switch (employeeType)
            {
                case EmployeeType.Teacher: employee = FactoryPattern<IEmployee, Teacher>.GetInstance();         // new Teacher() { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                    break;
                case EmployeeType.Manager: employee = FactoryPattern<IEmployee, Manager>.GetInstance();
                    break;
                case EmployeeType.HeadManager: employee = FactoryPattern<IEmployee, HeadManager>.GetInstance();
                    break;
                case EmployeeType.Ceo: employee = FactoryPattern<IEmployee, Ceo>.GetInstance();
                    break;
            }
            if(! employee.Equals(null))
            {
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Salary = salary;
            }
            return employee;
        }
    }
    
}
