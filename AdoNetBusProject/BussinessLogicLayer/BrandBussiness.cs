using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BrandBussiness : IBussiness<Brand>
    {
        Employee emp = new Employee();

        public BrandBussiness(Employee employee)
        {
            emp = employee;
        }
        int affectedRows;

        BrandDataMapper _brandDataMap = new BrandDataMapper();

        public List<Brand> GetAllBLL()
        {
            List<Brand> allBrands = _brandDataMap.GetAll();
            return allBrands;
        }

        public Brand GetBLL(int key)
        {
            Brand brand;

            if (key > 0)
            {
                return brand = _brandDataMap.Get(key);
            }
            else
            {
                throw new Exception("Hatalı id değeri girildi !");
            }
        }

        public bool SaveBLL(Brand item)
        {

            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Name))
                    {
                        return false;
                    }
                    int affectedRows = _brandDataMap.Insert(item);

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

        public bool UpdateBLL(Brand item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Name))
                    {
                        return false;
                    }
                    int affectedRows = _brandDataMap.Update(item);

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

        public bool DeleteBLL(Brand item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _brandDataMap.Delete(item);
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
