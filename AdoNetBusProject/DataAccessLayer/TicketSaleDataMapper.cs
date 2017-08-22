using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TicketSaleDataMapper : IDataMapper<TicketSale>
    {
        SqlCommand _command;

        public TicketSaleDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public List<TicketSale> GetAll()
        {
            /*  create proc sp_GetAllTicketSale
                as
                begin
                select TicketID,SaleID from  TicketSale
                end
            */
            List<TicketSale> ticketSaleList = new List<TicketSale>();
            _command.CommandText = "sp_GetAllTicketSale";
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
                            TicketSale ticketSale = new TicketSale();
                            ticketSale.TicketID = (int)reader[0];
                            ticketSale.SaleID = (int)reader[1];

                            ticketSaleList.Add(ticketSale);
                        }
                    }


                }
            }
            catch (Exception)
            {
                throw new Exception("TicketSaleDataMapper GetAll metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return ticketSaleList;
        }

        public TicketSale Get(int key)
        {
            /*
                create proc sp_GetTicketSaleByID
                @id int
                as
                begin
                select TicketID,SaleID from TicketSale where TicketID = @id
                end
            */
            TicketSale ticketSale = new TicketSale();
            _command.CommandText = "sp_GetTicketSaleByID";
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
                            ticketSale.TicketID = (int)reader[0];
                            ticketSale.SaleID = (int)reader[1];
                        }
                    }

                }
            }
            catch
            {
                throw new Exception("TicketSaleDataMapper GetByID metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return ticketSale;
        }

        public int Delete(TicketSale item)
        {
            /*
                create proc sp_DeleteFromTicketSale
                @id int
                as
                begin
                delete from TicketSale where TicketID = @id
                end
           */
            int affecttedRows = 0;

            try
            {
                _command.CommandText = "sp_DeleteFromTicketSale";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.TicketID);

                affecttedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("TicketSaleDataMapper Delete Metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affecttedRows;
        }
        
        public int Insert(TicketSale item)
        {
            int affectedRows = 0;

            /*
                create proc sp_InsertIntoTicketSale
                @ticketID int,
                @saleID int
                as
                begin
                insert into TicketSale(TicketID,SaleID) values(@ticketID, @saleID)
                end
             */
            try
            {
                _command.CommandText = "sp_InsertIntoTicketSale";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@routeID", item.TicketID);
                _command.Parameters.AddWithValue("@cityID", item.SaleID);

                affectedRows = _command.ExecuteNonQuery();
            }

            catch
            {
                throw new Exception("TicketSaleDataMapper Insert metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

        public int Update(TicketSale item)
        {
            int affectedRows = 0;

            /*  create proc sp_UpdateTicketSale
                @ticketId int,
                @saleID int
                as
                begin
                update TicketSale set TicketID = @ticketId where SaleID = @saleID
                end
             
             */

            try
            {
                _command.CommandText = "sp_UpdateTicketSale";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@routeID", item.TicketID);
                _command.Parameters.AddWithValue("@cityID", item.SaleID);

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("TicketSaleDataMapper Update metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }
    }
}
