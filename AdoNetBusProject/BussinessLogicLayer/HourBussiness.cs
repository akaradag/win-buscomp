using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class HourBussiness : IBussiness<Hour>
    {
        Employee employee ;

        int affectedRows;

        HourDataMapper _hourDataMap = new HourDataMapper();
        //ctor
        public HourBussiness(Employee emp)
        {
            this.employee = emp;
        }

        public List<Hour> GetAllBLL()
        {

            List<Hour> allHours = _hourDataMap.GetAll();
            return allHours;

        }

        public Hour GetBLL(int key)
        {
            Hour hour;


            if (key > 0)
            {
                return hour = _hourDataMap.Get(key);
            }
            else
            {
                throw new Exception("BLL006 : Hatalı id girildi.");
            }


        }

        public bool SaveBLL(Hour item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (item.DepartureTime == null)
                    {
                        return false;
                    }

                    int affectedRows = _hourDataMap.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL006 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }

        }

        public bool UpdateBLL(Hour item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (item.DepartureTime == null)
                    {
                        return false;
                    }
                    int affectedRows = _hourDataMap.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL006 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(Hour item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _hourDataMap.Delete(item);

                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("BLL006 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
