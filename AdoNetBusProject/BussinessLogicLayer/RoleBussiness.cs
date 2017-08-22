using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class RoleBussiness : IBussiness<Role>
    {
        Employee employee = new Employee();

        int affectedRows;

        RoleDataMapper _roleDataMapper = new RoleDataMapper();

        public RoleBussiness(Employee emp)
        {
            this.employee = emp;
        }

        public List<Role> GetAllBLL()
        {
            List<Role> allRole = _roleDataMapper.GetAll();
            return allRole;
        }

        public Role GetBLL(int key)
        {
            Role role;

            if (key > 0)
            {
                return role = _roleDataMapper.Get(key);
            }
            else
            {
                throw new Exception("BLL010 : Hatalı id değeri girildi ");
            }
        }

        public bool SaveBLL(Role item)
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
                    int affectedRows = _roleDataMapper.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL010 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(Role item)
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
                    int affectedRows = _roleDataMapper.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL010 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(Role item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _roleDataMapper.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("BLL010 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
