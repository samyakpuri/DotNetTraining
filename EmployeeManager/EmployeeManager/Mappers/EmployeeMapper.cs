using EmployeeManager.DataModel;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Mappers
{
    class EmployeeMapper
    {
        public static void Map(Employee employee,EmployeeModel employeeModel)
        {
            employeeModel.EmployeeId = employee.EmployeeId;
            employeeModel.Name = employee.FirstName + " " + employee.LastName;
            employeeModel.Address = employee.Address;
            employeeModel.ContactNo = employee.ContactNo;
            employeeModel.DOB = employee.DOB;
            employeeModel.CreateDate = employee.CreateDate;
            employeeModel.LastUpdated = employee.LastUpdated;
            employeeModel.Salary = employee.Salary;
            employeeModel.Gender = employee.Gender;
            employeeModel.Department = employee.Department1.DepartmentName;
            employeeModel.Designation = employee.Designation;
            employeeModel.Project = employee.Project1.ProjectName;
            employeeModel.Email = employee.Email;
        }

        public static void MapBack(Employee employee,EmployeeModel employeeModel)
        {
            employee.EmployeeId = employeeModel.EmployeeId;
            var temp = employeeModel.Name.Split(null).ToList();
            employee.FirstName = temp[0];
            employee.LastName = temp[1];
            employee.Address = employeeModel.Address;
            employee.ContactNo = employeeModel.ContactNo;
            employee.DOB = employeeModel.DOB;
            employee.CreateDate = employeeModel.CreateDate;
            employee.LastUpdated = employeeModel.LastUpdated;
            employee.Salary = employeeModel.Salary;
            employee.Gender = employeeModel.Gender;
            employee.Department = employeeModel.Department;
            employee.Designation = employeeModel.Designation;
            employee.Project = employeeModel.Project;
            employee.Email = employeeModel.Email;
        }
        }
    }
    }
}
