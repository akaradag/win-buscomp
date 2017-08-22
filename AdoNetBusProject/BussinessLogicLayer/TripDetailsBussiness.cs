using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class TripDetailsBussiness: IBussiness<TripDetails>
    {
        Employee _emp ;

        int affectedRows;

        TripDetailsDataMapper _tripDetDataMap ;

        public TripDetailsBussiness(Employee employee)
        {
            _emp = employee;
            _tripDetDataMap = new TripDetailsDataMapper();
        }

        public List<TripDetails> GetAllBLL()
        {
            List<TripDetails> allTripDetails = _tripDetDataMap.GetAll();
            return allTripDetails;
        }

        public TripDetails GetBLL(int key)
        {
            TripDetails tripdetails;

            if (key > 0)
            {
                return tripdetails = _tripDetDataMap.Get(key);
            }
            else
            {
                throw new Exception("Hatalı id değeri girildi !");
            }
        }
        /// <summary>
        /// Seyahat detaylarını daha detaylı getirir.
        /// </summary>
        /// <returns></returns>
        public List<TripDetails> GetAllwDetailsBLL()
        {
            List<TripDetails> allTripDetails = _tripDetDataMap.GetAll();
            return allTripDetails;
        }

        public bool SaveBLL(TripDetails item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripDetDataMap.Insert(item);

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

        public bool UpdateBLL(TripDetails item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {

                    int affectedRows = _tripDetDataMap.Update(item);

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

        public bool DeleteBLL(TripDetails item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _tripDetDataMap.Delete(item);
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
