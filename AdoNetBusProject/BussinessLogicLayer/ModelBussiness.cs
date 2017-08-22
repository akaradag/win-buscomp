using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class ModelBussiness : IBussiness<Model>
    {
        Employee emp = new Employee();

        int affectedRows;
        public ModelBussiness(Employee employee)
        {
            emp = employee;
        }
        ModelDataMapper _modelDataMap = new ModelDataMapper();

        public List<Model> GetAllBLL()
        {
            List<Model> allModel = _modelDataMap.GetAll();
            return allModel;
        }

        public Model GetBLL(int key)
        {
            Model model;

            if (key > 0)
            {
                return model = _modelDataMap.Get(key);
            }
            else
            {
                throw new Exception("BLL007 : Hatalı id girildi.");
            }

        }

        public bool SaveBLL(Model item)
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
                    int affectedRows = _modelDataMap.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }

                return result;

            }
            else
            {
                throw new Exception("BLL007 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(Model item)
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
                    int affectedRows = _modelDataMap.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL007 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(Model item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _modelDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("BLL007 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
