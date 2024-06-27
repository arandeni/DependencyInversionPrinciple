using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class DataAccessFactory
    {
        /*public static EmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }*/

        public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj() 
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
