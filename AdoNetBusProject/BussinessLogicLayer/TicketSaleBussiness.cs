using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class TicketSaleBussiness : IBussiness<TicketSale>
    {
        Employee emp = new Employee();
        int affectedRows = 0;
        TicketSaleDataMapper _ticketSaleDataMap = new TicketSaleDataMapper();

        // Constructor
        public TicketSaleBussiness(Employee employee)
        {
            emp = employee; 
        }
        
        
        public List<TicketSale> GetAllBLL()
        {
            List<TicketSale> allTicketSale = _ticketSaleDataMap.GetAll();
            return allTicketSale;
        }

        public TicketSale GetBLL(int key)
        {
            TicketSale ticketSale;
            if (key > 0)
            {
                return ticketSale = _ticketSaleDataMap.Get(key);
            }
            else
            {
                throw new Exception("BiletSatış'ı görmek için geçerli ID değerini giriniz.(TicketSaleBusiness GetBLL(int key)");
            }
        }

        public bool SaveBLL(TicketSale item)
        {
            if (emp.ID == 1 || emp.ID == 2)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.TicketID.ToString()))
                    {
                        return false;
                    }

                    int affectedRows = 0;
                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici ve satış görevlisi haricinde biletsatış kaydı yapılamaz.(TicketSaleBusiness SaveBLL)");

            }
        }

        public bool UpdateBLL(TicketSale item)
        {
            if (emp.RoleID == 1 || emp.RoleID == 2)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.TicketID.ToString()))
                    {
                        return false;
                    }
                }
                int affectedRows = _ticketSaleDataMap.Update(item);
                if (affectedRows > 0)
                {
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici veya satış görevlisi olmadan biletsatış günceleme işlemi yapılamaz.(TicketSaleBusiness UpdateBLL)");
            }
        }

        public bool DeleteBLL(TicketSale item)
        {
            if (emp.ID == 1 || emp.ID == 2)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _ticketSaleDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;

            }
            else
            {
                throw new Exception("Yönetici ve satış elemanı haricinde biletsatış silme yapılamaz.(TicketSaleBusiness DeleteBLL)");
            }
        }
    }
}
