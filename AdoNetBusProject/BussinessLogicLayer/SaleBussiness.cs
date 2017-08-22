using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class SaleBussiness : IBussiness<Sale>
    {
        Employee emp = new Employee();
        int affectedRows = 0;
        SaleDataMapper _saleDataMap = new SaleDataMapper();
        private Employee _employee;

        public SaleBussiness(Employee employee)
        {
            emp = employee;
        }

        public List<Sale> GetAllBLL()
        {
            List<Sale> allSale = _saleDataMap.GetAll();
            return allSale;
        }

        public Sale GetBLL(int key)
        {
            Sale sale;
            if(key > 0)
            {
                return sale = _saleDataMap.Get(key);
            }
            else
            {
                throw new Exception("Satışı görmek için geçerli ID değerini giriniz.(SaleBusiness GetBLL(int key))");
            }
        }

        public bool SaveBLL(Sale item)
        {
           if(emp.ID == 1 || emp.ID == 2)
            {
                bool result = false;
                if(item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Date.ToString()) || string.IsNullOrWhiteSpace(item.TotalPrice.ToString()) || string.IsNullOrWhiteSpace(item.PaymentID.ToString()))
                    {
                        return false;
                    }

                    int affectedRows = 0;
                    if(affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici ve satış görevlisi haricinde satış kaydı yapılamaz.(SaleBusiness SaveBLL(Sale item)");
            }
        }

        public bool UpdateBLL(Sale item)
        {
            if(emp.RoleID == 1 || emp.RoleID == 2)
            {
                bool result = false;
                if(item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.Date.ToString()) || string.IsNullOrWhiteSpace(item.TotalPrice.ToString()) || string.IsNullOrWhiteSpace(item.PaymentID.ToString()))
                        {
                        return false;
                    }
                    int affectedRows = _saleDataMap.Update(item);
                    
                    if(affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                    
                }
                return result;
            }
            else
            {
                throw new Exception("Yönetici ve satış görevlisi haricinde satış güncelleme işlemi yapılamaz.(SaleBusiness UpdateBLL)");
            }
        }

        public bool DeleteBLL(Sale item)
        {
            if(emp.ID == 1 || emp.ID == 2)
            {
                bool result = false;
                if(item != null)
                {
                    int affectedRows = _saleDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
               
            }
            else
            {
                throw new Exception("Yönetici ve satış elemanı haricinde satış silme yapılamaz.(SaleBusiness DeleteBLL)");
            }
        }
    }
}
