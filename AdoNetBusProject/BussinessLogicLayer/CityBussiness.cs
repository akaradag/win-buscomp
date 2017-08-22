using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class CityBussiness : IBussiness<City>
    {
        Employee employee = new Employee();

        int affectedRows;

        CityDataMapper _cityDataMap = new CityDataMapper();
        

        public CityBussiness(Employee _employee)
        {
            this.employee = _employee;
        }

        public List<City> GetAllBLL()
        {
            List<City> allCity = _cityDataMap.GetAll();
            return allCity;
        }

        public City GetBLL(int key)
        {
            City city;

            if (key > 0)
            {
                return city = _cityDataMap.Get(key);
            }
            else
            {
                throw new Exception("A002 : Hatalı id değeri girildi !");
            }
        }

        public bool SaveBLL(City item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Name))
                    {
                        return false;
                    }
                    int affectedRows = _cityDataMap.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("A002 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(City item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Name))
                    {
                        return false;
                    }
                    int affectedRows = _cityDataMap.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("A002 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(City item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    affectedRows = _cityDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("A002 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
