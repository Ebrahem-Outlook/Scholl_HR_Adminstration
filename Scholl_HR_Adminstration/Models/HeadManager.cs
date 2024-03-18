using HR_Adminstration_API;

namespace Scholl_HR_Adminstration.Models
{
    public class HeadManager : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.05M; }
    }
}
