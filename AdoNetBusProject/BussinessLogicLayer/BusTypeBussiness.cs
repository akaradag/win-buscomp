using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BusTypeBussiness : IBussiness<BusType>
    {
        

        int affectedRows = 0;
        BusTypeDataMapper _typeMapper;
        Employee emp = new Employee();
        public BusTypeBussiness(Employee employee)
        {
            _typeMapper = new BusTypeDataMapper();
            // TODO: emp id gelicek
            emp = employee;
        }

        public List<BusType> GetAllBLL()
        {
            List<BusType> lstType = _typeMapper.GetAll();

            return lstType;
        }

        public BusType GetBLL(int key)
        {
            BusType busType;
            if (key > 0)
            {
                busType = _typeMapper.Get(key);
            }
            else
            {
                throw new Exception("A002:Hatalı değer girdiniz.");
            }
            return busType;
        }

        public bool SaveBLL(BusType item)
        {
            bool result = false;
            if (emp.RoleID == 1)
            {

                if (item != null)
                {

                    if (string.IsNullOrEmpty(item.Name.Trim()))
                    {
                        return false;
                    }
                    affectedRows = _typeMapper.Insert(item);
                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
            }
            else
            {
                throw new Exception("A002: Yönetici dışında ekleme işlemi yapılamaz.");
            }
            return result;
        }

        public bool UpdateBLL(BusType item)
        {
            bool result = false;
            if (emp.RoleID == 1)
            {

                if (item != null)
                {

                    if (string.IsNullOrEmpty(item.Name.Trim()))
                    {
                        return false;
                    }
                    affectedRows = _typeMapper.Update(item);
                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
            }
            else
            {
                throw new Exception("A002: Yönetici dışında güncelleme işlemi yapılamaz.");
            }
            return result;
        }

        public bool DeleteBLL(BusType item)
        {
            bool result = false;
            if (emp.RoleID == 1)
            {
                if (item != null)
                {
                    affectedRows = _typeMapper.Delete(item);
                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
            }
            else
            {
                throw new Exception("A002: Yönetici dışında silme işlemi yapılamaz.");
            }
            return result;
        }
    }
}
