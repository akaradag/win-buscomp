using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class TripPassengerBussiness : IBussiness<TripPassenger>
    {

        Employee emp = new Employee();

        int affectedRows;

        TripPassengerDataMapper _tripPasDataMap = new TripPassengerDataMapper();

        public List<TripPassenger> GetAllBLL()
        {
            List<TripPassenger> allTripPassenger = _tripPasDataMap.GetAll();
            return allTripPassenger;
        }

        public TripPassenger GetBLL(int key)
        {
            TripPassenger trippassenger;

            if (key > 0)
            {
                return trippassenger = _tripPasDataMap.Get(key);
            }
            else
            {
                throw new Exception("Hatalı id değeri girildi !");
            }
        }

        public bool SaveBLL(TripPassenger item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripPasDataMap.Insert(item);

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

        public bool UpdateBLL(TripPassenger item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    
                    int affectedRows = _tripPasDataMap.Update(item);

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

        public bool DeleteBLL(TripPassenger item)
        {
            if (emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripPasDataMap.Delete(item);
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
