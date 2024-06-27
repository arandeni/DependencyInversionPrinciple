using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmployeeBusinessLogic
    {
        //EmployeeDataAccessLogic employeeDataAccessLogic;
        IEmployeeDataAccessLogic employeeDataAccessLogic;

        public EmployeeBusinessLogic() 
        {
            employeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id) 
        {
            return employeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
