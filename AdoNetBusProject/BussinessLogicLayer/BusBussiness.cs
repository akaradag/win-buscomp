using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BusBussiness : IBussiness<Bus>
    {
        Employee _emp = new Employee();
        int affectedRows = 0;
        BusDataMapper _busDataMap = new BusDataMapper();

        // Constructor
        public BusBussiness(Employee employee)
        {
            _emp = employee;
        }      

        public List<Bus> GetAllBLL()
        {
            List<Bus> allBus = _busDataMap.GetAll();
            return allBus;
        }
        public List<Bus> GetAllByDate(DateTime startDate, DateTime endDate)
        {
            List<Bus> allBus = _busDataMap.GetAllBusByDate(startDate, endDate);
            return allBus;
        }

        public Bus GetBLL(int key)
        {
            Bus bus;

            if(key > 0)
            {
                return bus = _busDataMap.Get(key);
            }
            else
            {
                throw new Exception("Otobüs değerini okumak için doğru ID değeri giriniz.(BusBusiness GetBLL(key))");
            }
        }

        public bool SaveBLL(Bus item)
        {
            if(_emp.RoleID == 1)
            {
                bool result = false;
                if(item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.SeatCount.ToString()))
                    {
                        return false;
                    }

                    int affectedRows = _busDataMap.Insert(item);
                    if(affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }


                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında otobüs kaydı eklenemez.(BusBusiness SaveBLL)");
            }
        }

        public bool UpdateBLL(Bus item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.SeatCount.ToString()))
                    {
                        return false;
                    }
                    int affectedRows = _busDataMap.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında otobüs kayıt güncelleme işlemi yapılamaz.(BusBusiness UpdateBLL)");
            }
        }

        public bool DeleteBLL(Bus item)
        {
            if (_emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _busDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında otobüs kayıt silme işlemi yapılamaz.(BusBusiness DeleteDLL)");
            }
        }
    }
}
