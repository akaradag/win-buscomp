using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using DataAccessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class RouteBussiness : IBussiness<Route>
    {
        Employee emp = new Employee();
        int affectedRows = 0;
        RouteDataMapper _routeMapper = new RouteDataMapper();

        public RouteBussiness(Employee employee)
        {
            emp = employee;
        }

        public List<Route> GetAllBLL()
        {
            List<Route> allRoute = _routeMapper.GetAll();
            return allRoute;
        }

        public Route GetBLL(int key)
        {
            Route route = new Route();
            if(key > 0)
            {
                return route = _routeMapper.Get(key);
            }
            else
            {
                throw new Exception("RouteBusiness GetBLL(int key) metodunda hata oluştu.");
            }
        }

        public bool SaveBLL(Route item)
        {
            if(emp.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Name) || string.IsNullOrWhiteSpace(item.Price.ToString()))
                    {
                        return false;
                    }
                    affectedRows = _routeMapper.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında rota eklenemez.(RouteBusiness SaveBLL)");
            }
            
        }

        public bool UpdateBLL(Route item)
        {
            if(emp.RoleID == 1)
            {
                bool result = false;
                if(item != null)
                {
                    if(string.IsNullOrWhiteSpace(item.Name) || string.IsNullOrWhiteSpace(item.Price.ToString()))
                    {
                        return false;
                    }

                    int affectedRows = _routeMapper.Update(item);
                    if(affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                  }
                return result;
            }
            else
            {
                throw new Exception("Yönetici dışında rota güncellenemez.(RouteBusiness UpdateBLL)");
            }
        }

        public bool DeleteBLL(Route item)
        {
            if(emp.RoleID == 1)
            {
                bool result = false;
                if(item != null)
                {
                    int affectedRows = _routeMapper.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici haricinde rota silinemez.(RouteBusiness Delete(route item))");
            }
        }
    }
}
