using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class TripBussiness : IBussiness<Trip>
    {
        Employee emp = new Employee();

        int affectedRows;

        TripDataMapper _tripDataMap = new TripDataMapper();

        //ctor
        public TripBussiness(Employee employee)
        {
            emp = employee;
        }

        public List<Trip> GetAllBLL()
        {
            List<Trip> allTrip = _tripDataMap.GetAll();
            return allTrip;
        }

        public Trip GetBLL(int key)
        {
            Trip trip;

            if (key > 0)
            {
                return trip = _tripDataMap.Get(key);
            }
            else
            {
                throw new Exception("Hatalı id değeri girildi !");
            }
        }

        public bool SaveBLL(Trip item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripDataMap.Insert(item);

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

        public bool UpdateBLL(Trip item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {

                    int affectedRows = _tripDataMap.Update(item);

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

        public bool DeleteBLL(Trip item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripDataMap.Delete(item);
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
