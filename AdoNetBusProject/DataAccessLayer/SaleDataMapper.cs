using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class SaleDataMapper : IDataMapper<Sale>
    {
        SqlCommand _command;
        public SaleDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        public List<Sale> GetAll()
        {
            /*
                create proc sp_GetAllSale
                as
                begin
                select ID, [Date], TotalPrice, PaymentID from  Sale
                end
             */
            List<Sale> saleList = new List<Sale>();
            _command.CommandText = "sp_GetAllSale";
            _command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                    SqlDataReader reader = _command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Sale sale = new Sale();
                            sale.ID = (int)reader[0];
                            sale.Date = (DateTime)reader[1];
                            sale.TotalPrice = (decimal)reader[2];
                            sale.PaymentID = (int)reader[3];

                            saleList.Add(sale);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("SaleDataMapper GetAll metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return saleList;
        }
        public Sale Get(int key)
        {
            /*
             *  create proc sp_GetSaleByID
                @id int
                as
                begin
                select [Date], TotalPrice, PaymentID from Sale where ID = @id
                end
             */

            Sale sale = new Sale();
            _command.CommandText = "sp_GetSaleByID";
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@id", key);

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sale.ID = (int)reader[0];
                            sale.Date = (DateTime)reader[1];
                            sale.TotalPrice = (decimal)reader[2];
                            sale.PaymentID = (int)reader[3];
                        }
                    }

                }
            }
            catch
            {
                throw new Exception("SaleDateMapper GetByID metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return sale;
        }

        public int Delete(Sale item)
        {
            int affecttedRows = 0;

            /*
                create proc sp_DeleteFromSale
                @id int
                as
                begin
                delete from Sale where ID = @id
                end
             */

            try
            {
                _command.CommandText = "sp_DeleteFromSale";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);

                affecttedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("SaleDataMapper Delete Metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affecttedRows;
        }

        public int Insert(Sale item)
        {
            int affectedRows = 0;
            /*
                create proc sp_InsertIntoSale
                @date datetime,
                @totalPrice decimal(5,2),
                @paymentId int
                as
                begin
                insert into Sale([Date],TotalPrice, PaymentID) values(@date,@totalPrice,@paymentId)
                end
             */

            try
            {
                _command.CommandText = "sp_InsertIntoRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);
                _command.Parameters.AddWithValue("@name", item.Date);
                _command.Parameters.AddWithValue("@price", item.TotalPrice);
                _command.Parameters.AddWithValue("@paymentId", item.PaymentID);

                affectedRows = _command.ExecuteNonQuery();
            }

            catch
            {
                throw new Exception("SaleDataMapper Insert metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

        public int Update(Sale item)
        {
            int affectedRows = 0;

            /*
             *  create proc sp_UpdateSale
                @id int,
                @date datetime,
                @totalPrice decimal(5,2),
                @paymentId int
                as
                begin
                update Sale set  [Date] = @date, TotalPrice = @totalPrice, PaymentID = @paymentId where ID = @id
                end
             */

            try
            {


                _command.CommandText = "sp_UpdateRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);
                _command.Parameters.AddWithValue("@date", item.Date);
                _command.Parameters.AddWithValue("@totalPrice", item.TotalPrice);
                _command.Parameters.AddWithValue("@paymentId", item.PaymentID);

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("SaleDataMapper Update metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }
    }
}
