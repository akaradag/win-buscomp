using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class EmployeeBussiness : IBussiness<Employee>
    {
        Employee emp = new Employee();
        int affectedRows = 0;
        EmployeeDataMapper employeeDataMap = new EmployeeDataMapper();

        //Constuctor
        public EmployeeBussiness(Employee employee)
        {
            this.emp = employee;
        }

        public List<Employee> GetAllBLL()
        {
            List<Employee> allEmployee = employeeDataMap.GetAll();
            return allEmployee;
        }
        /// <summary>
        /// Seyahat için girilen tarihlerde müsait çalışanları getirir.
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllTripByDateEmp(DateTime startDate,DateTime endDate)
        {
            List<Employee> allEmployee = employeeDataMap.GetAll();
            return allEmployee;
        }

        public Employee GetBLL(int key)
        {
            Employee employee;

            if (key > 0)
            {
                return employee = employeeDataMap.Get(key);
            }
            else
            {
                throw new Exception("Çalışan bilgilerine ulaşmak için doğru ID değerini giriniz.(EmployeeBusiness GetBLL(key))");
            }
        }

        public bool SaveBLL(Employee item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.FirstName) || (string.IsNullOrWhiteSpace(item.LastName)) || (string.IsNullOrWhiteSpace(item.Phone))
                        || (string.IsNullOrWhiteSpace(item.BirthDate.ToString())) || (string.IsNullOrWhiteSpace(item.HireDate.ToString())) ||
                       (string.IsNullOrWhiteSpace(item.Mail)) || (string.IsNullOrWhiteSpace(item.Password)))
                    {
                        return false;
                    }

                    int affectedRows = employeeDataMap.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici haricinde çalışan kaydı yapılamaz.(EmployeeBusiness SaveBLL)");

            }
        }

        public bool UpdateBLL(Employee item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.FirstName) || (string.IsNullOrWhiteSpace(item.LastName)) || (string.IsNullOrWhiteSpace(item.Phone))
                         || (string.IsNullOrWhiteSpace(item.BirthDate.ToString())) || (string.IsNullOrWhiteSpace(item.HireDate.ToString())) ||
                        (string.IsNullOrWhiteSpace(item.Mail)) || (string.IsNullOrWhiteSpace(item.Password)))
                    {
                        return false;
                    }

                    int affectedRows = employeeDataMap.Update(item);
                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında çalışan güncellenemez.(EmployeeBusiness UpdateBLL)");
            }
        }

        public bool DeleteBLL(Employee item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    affectedRows = employeeDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici haricinde çalışan silinemez.(EmployeeBusiness DeleteDLL");
            }
        }
    }
}
