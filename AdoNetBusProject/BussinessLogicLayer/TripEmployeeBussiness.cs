using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class TripEmployeeBussiness : IBussiness<TripEmployee>
    {
        Employee _emp;

        int affectedRows;

        TripEmployeeDataMapper _tripEmpDataMap;
        
        public TripEmployeeBussiness(Employee employee)
        {
            _emp = employee;
            _tripEmpDataMap = new TripEmployeeDataMapper();
        }

        public List<TripEmployee> GetAllBLL()
        {
            List<TripEmployee> allTripEmployee = _tripEmpDataMap.GetAll();
            return allTripEmployee;
        }

        public TripEmployee GetBLL(int key)
        {
            TripEmployee tripemployee;

            if (key > 0)
            {
                return tripemployee = _tripEmpDataMap.Get(key);
            }
            else
            {
                throw new Exception("Hatalı id değeri girildi !");
            }
        }

        public bool SaveBLL(TripEmployee item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripEmpDataMap.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL001 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(TripEmployee item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {

                    int affectedRows = _tripEmpDataMap.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL001 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(TripEmployee item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripEmpDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("BLL001 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
