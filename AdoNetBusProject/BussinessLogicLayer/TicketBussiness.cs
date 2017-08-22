using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{

    public class TicketBussiness : IBussiness<Ticket>
    {
        Employee emp = new Employee();
        int affectedRows = 0;
        TicketDataMapper _ticketDataMap = new TicketDataMapper();
        private Employee _employee;

        public TicketBussiness(Employee _employee)
        {
            this._employee = _employee;
        }

        public List<Ticket> GetAllBLL()
        {
            List<Ticket> allTicket = _ticketDataMap.GetAll();
            return allTicket;
        }

        public Ticket GetBLL(int key)
        {
            Ticket ticket;
            if(key > 0)
            {
                return ticket = _ticketDataMap.Get(key);
            }
            else
            {
                throw new Exception("Bileti görmek için geçerli ID değerini giriniz.(TicketBusiness GetBLL(int key)");
            }
        }

        public bool SaveBLL(Ticket item)
        {
            if(emp.ID == 1 || emp.ID == 2)
            {
                bool result = false;
                if(item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.SeatNumber.ToString()) || string.IsNullOrWhiteSpace(item.Price.ToString()))
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
                throw new Exception("Yönetici ve satış görevlisi haricinde bilet kaydı yapılamaz.(TicketBusiness SaveBLL)");

            }
            
            


        }

        public bool UpdateBLL(Ticket item)
        {
           if(emp.RoleID == 1 || emp.RoleID == 2)
            {
                bool result = false;
                if(item != null)
                {
                    if(string.IsNullOrWhiteSpace(item.SeatNumber.ToString()) || string.IsNullOrWhiteSpace(item.Price.ToString()))
                    {
                        return false;
                    }
                }
                int affectedRows = _ticketDataMap.Update(item);
                if(affectedRows > 0)
                {
                    result = affectedRows > 0;
                }
                return result;
            }
           else
            {
                throw new Exception("Yönetici veya satış görevlisi olmadan bilet günceleme işlemi yapılamaz.(TicketBusiness UpdateBLL)");
            }

            
        }

        public bool DeleteBLL(Ticket item)
        {
            if (emp.ID == 1 || emp.ID == 2)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _ticketDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;

            }
            else
            {
                throw new Exception("Yönetici ve satış elemanı haricinde bilet silme yapılamaz.(TicketBusiness DeleteBLL)");
            }
        }
    }
}
