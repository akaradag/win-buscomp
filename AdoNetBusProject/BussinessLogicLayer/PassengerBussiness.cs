using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class PassengerBussiness : IBussiness<Passenger>
    {
        Employee employee = new Employee();

        int affectedRows;

        PassengerDataMapper _passengerDataMapper = new PassengerDataMapper();

        public List<Passenger> GetAllBLL()
        {

            List<Passenger> allPassengers = _passengerDataMapper.GetAll();
            return allPassengers;
        }

        public Passenger GetBLL(int key)
        {
            Passenger passenger;

            if (key > 0)
            {
                return passenger = _passengerDataMapper.Get(key);
            }
            else
            {
                throw new Exception("BLL008 : Hatalı id girildi.");
            }
        }

        public bool SaveBLL(Passenger item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.FirstName))
                    {
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(item.LastName))
                    {
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(item.Phone))
                    {
                        return false;
                    }
                    else if (item.SocialNumber == null || item.SocialNumber < 0)
                    {
                        return false;
                    }

                    int affectedRows = _passengerDataMapper.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL008 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(Passenger item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.FirstName))
                    {
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(item.LastName))
                    {
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(item.Phone))
                    {
                        return false;
                    }
                    else if (item.SocialNumber == null || item.SocialNumber < 0)
                    {
                        return false;
                    }

                    int affectedRows = _passengerDataMapper.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL008 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(Passenger item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _passengerDataMapper.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("BLL008 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
