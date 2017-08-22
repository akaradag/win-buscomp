using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class PaymentBussiness:IBussiness<Payment>
    {
        Employee employee = new Employee();

        int affectedRows;

        PaymentDataMapper _paymentDataMap = new PaymentDataMapper();
        

        public PaymentBussiness(Employee _employee)
        {
            this.employee = _employee;
        }

        public List<Payment> GetAllBLL()
        {
            List<Payment> allPayment = _paymentDataMap.GetAll();
            return allPayment;
        }

        public Payment GetBLL(int key)
        {
            Payment paymnet;

            if (key > 0)
            {
                return paymnet = _paymentDataMap.Get(key);
            }
            else
            {
                throw new Exception("BLL009 : Hatalı id değeri girildi !");
            }
        }

        public bool SaveBLL(Payment item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.PaymenType))
                    {
                        return false;
                    }
                    int affectedRows = _paymentDataMap.Insert(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL009 : Yönetici dışında kayıt ekleme işlemi yapılamaz.");
            }
        }

        public bool UpdateBLL(Payment item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    if (string.IsNullOrWhiteSpace(item.PaymenType))
                    {
                        return false;
                    }
                    int affectedRows = _paymentDataMap.Update(item);

                    if (affectedRows > 0)
                    {
                        result = affectedRows > 0;
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("BLL009 : Yönetici dışında kayıt güncelleme işlemi yapılamaz.");
            }
        }

        public bool DeleteBLL(Payment item)
        {
            if (employee.RoleID == 1)
            {
                bool result = false;
                if (item != null)
                {
                    int affectedRows = _paymentDataMap.Delete(item);
                    result = affectedRows > 0;
                }
                return result;
            }
            else
            {
                throw new Exception("BLL009 : Yönetici dışında kayıt silme işlemi yapılamaz.");
            }
        }
    }
}
