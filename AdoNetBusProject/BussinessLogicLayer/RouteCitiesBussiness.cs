using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class RouteCitiesBussiness : IBussiness<RouteCities>
    {
        Employee emp = new Employee();
        int affectedRows = 0;
        RouteCitiesDataMapper _routeCitiesMapper = new RouteCitiesDataMapper();

        public RouteCitiesBussiness(Employee employee)
        {
            emp = employee;
        }
        
        public List<RouteCities> GetAllBLL()
        {
            List<RouteCities> allRouteCities = _routeCitiesMapper.GetAll();
            return allRouteCities;
        }
        /// <summary>
        /// Route' a ait ilk şehrin bilgilerini kontrollü getirir.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public RouteCities GetBLL(int key)
        {
            RouteCities routeCities;
            if(key > 0)
            {
                return routeCities = _routeCitiesMapper.Get(key);
            }
            else
            {
                throw new Exception("Hatalı Id değeri girdiniz.");
            }
        }
        /// <summary>
        /// Route' a ait ikinci şehrin bilgilerini kontrollü getirir.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public RouteCities GetSecondCityBLL(int key)
        {
            RouteCities routeCities;
            if (key > 0)
            {
                return routeCities = _routeCitiesMapper.GetSecondCity(key);
            }
            else
            {
                throw new Exception("Hatalı Id değeri girdiniz.");
            }
        }

        public bool SaveBLL(RouteCities item)
        {
            if(emp.RoleID == 1)
            {
                bool result = false;
                if(item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.CityID.ToString()) || string.IsNullOrWhiteSpace(item.RouteID.ToString()))
                    {
                        return false;
                    }
                    int affectedRows = _routeCitiesMapper.Insert(item);
                    if(affectedRows > 0)
                    {
                        return affectedRows > 0;
                    }

                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında RotaŞehir kaydı ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(RouteCities item)
        {
            if(emp.RoleID == 1)
            {
                bool result = false;
                if(item != null)
                {
                    if(string.IsNullOrWhiteSpace(item.CityID.ToString()) || string.IsNullOrWhiteSpace(item.RouteID.ToString()))
                    {
                        return false;
                    }

                    int affectedRows = _routeCitiesMapper.Update(item);
                
                    if(affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında rotaşehir güncellenemez.(RouteCities UpdateBLL(RouteCities item))");
            }
        }

        public bool DeleteBLL(RouteCities item)
        {
            if(emp.ID == 1)
            {
                bool result = false;
                if(item != null)
                {
                    int affectedRows = _routeCitiesMapper.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici haricinde rotaşehir silinemez.(RouteCities DeleteBLL(RouteCities item))");
            }
        }
    }
}
