using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PaymentDataMapper : IDataMapper<Payment>
    {
        SqlCommand _command;

        public PaymentDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Payment Get(int key)
        {
            Payment payment = new Payment();

            _command.CommandText = "select ID,PaymentType from Payment where ID=@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", key);

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        payment.ID = (int)reader["ID"];
                        payment.PaymenType = reader.GetString(1);

                    }
                }
                else
                {
                    throw new Exception("B004 : Bu id'ye ait bir kayıt bulunmamaktadır.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Connection.Close();
            }

            return payment;
        }

        public List<Payment> GetAll()
        {
            List<Payment> paymentList = new List<Payment>();

            _command.CommandText = "select ID,PaymentType from Payment";


            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Payment payment = new Payment();

                        payment.ID = (int)reader["ID"];
                        payment.PaymenType = reader.GetString(1);

                        paymentList.Add(payment);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Connection.Close();
            }

            return paymentList;
        }

        public int Insert(Payment item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into Payment(PaymentType) values (@paymentType)";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@paymentType", item.PaymenType);


            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                affectedRows = _command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

        public int Update(Payment item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update Payment set PaymentType=@paymentType where ID =@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);
            _command.Parameters.AddWithValue("@paymentType", item.PaymenType);


            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                affectedRows = _command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

        public int Delete(Payment item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from Payment where ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);


            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                affectedRows = _command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
    }
}
