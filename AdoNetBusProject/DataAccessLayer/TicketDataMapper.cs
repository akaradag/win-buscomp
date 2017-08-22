using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TicketDataMapper : IDataMapper<Ticket>
    {
        SqlCommand _command;

        public TicketDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public List<Ticket> GetAll()
        {
            /*
                create proc sp_GetAllTicket
                as
                begin
                select ID,PassengerID,EmployeeID,SeatNumber,TripID,Price,StartCityID,EndCityID from  Ticket
                end
             */
            List<Ticket> ticketList = new List<Ticket>();
            _command.CommandText = "sp_GetAllTicket";
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
                            Ticket ticket = new Ticket();
                            ticket.ID = (int)reader[0];
                            ticket.PassengerID = (int)reader[1];
                            ticket.EmployeeID = (int)reader[2];
                            ticket.SeatNumber = (int)reader[3];
                            ticket.TripID = (int)reader[4];
                            ticket.Price = (decimal)reader[5];
                            ticket.StartCityID = (int)reader[6];
                            ticket.EndCityID = (int)reader[7];

                            ticketList.Add(ticket);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("TicketDataMapper GetAll metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return ticketList;
        }

        public Ticket Get(int key)
        {
            /*
                create proc sp_GetTicketByID
                @id int
                as
                begin
                select ID,PassengerID,EmployeeID,SeatNumber,TripID,Price,StartCityID,EndCityID from Ticket where ID = @id
                end
             */
            Ticket ticket = new Ticket();
            _command.CommandText = "sp_GetTicketByID";
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
                            ticket.ID = (int)reader[0];
                            ticket.PassengerID = (int)reader[1];
                            ticket.EmployeeID = (int)reader[2];
                            ticket.SeatNumber = (int)reader[3];
                            ticket.TripID = (int)reader[4];
                            ticket.Price = (decimal)reader[5];
                            ticket.StartCityID = (int)reader[6];
                            ticket.EndCityID = (int)reader[7];
                        }
                    }

                }
            }
            catch
            {
                throw new Exception("TicketDateMapper GetByID metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return ticket;
        }

        public int Delete(Ticket item)
        {
            int affecttedRows = 0;

            /*
                create proc sp_DeleteFromTicket
                @id int
                as
                begin
                delete from Ticket where ID = @id
                end
             */

            try
            {
                _command.CommandText = "sp_DeleteFromTicket";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);

                affecttedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("TicketDataMapper Delete Metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affecttedRows;
        }

        public int Insert(Ticket item)
        {
            int affectedRows = 0;
            /*
                create proc sp_InsertIntoTicket
                @passengerId int,
                @employeeId int,
                @seatNumber int,
                @tripId int,
                @price decimal(5,2),
                @startCityId int,
                @endCityId int
                as
                begin
                insert into Ticket(PassengerID,EmployeeID,SeatNumber,TripID,Price,StartCityID,EndCityID) 
                values(@passengerId,@employeeId,@seatNumber,@tripId,@price,@startCityId,@endCityId)
                end
             */

            try
            {
                _command.CommandText = "sp_InsertIntoRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@passengerId", item.PassengerID);
                _command.Parameters.AddWithValue("@employeeId", item.EmployeeID);
                _command.Parameters.AddWithValue("@seatNumber", item.SeatNumber);
                _command.Parameters.AddWithValue("@tripId", item.TripID);
                _command.Parameters.AddWithValue("@price", item.Price);
                _command.Parameters.AddWithValue("@startCityId", item.StartCityID);
                _command.Parameters.AddWithValue("@endCityId", item.EndCityID);

                affectedRows = _command.ExecuteNonQuery();
            }

            catch
            {
                throw new Exception("TicketDataMapper Insert metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

        public int Update(Ticket item)
        {
            int affectedRows = 0;

            /*
             *  create proc sp_UpdateTicket
                @id int,
                @passengerId int,
                @employeeId int,
                @seatNumber int,
                @tripId int,
                @price decimal(5,2),
                @startCityId int,
                @endCityId int
                as
                begin
                update Ticket set PassengerID = @passengerId, EmployeeID = @employeeId, SeatNumber = @seatNumber,
                TripID = @tripId, Price = @price, StartCityID = @startCityId, EndCityID = @endCityId
                where ID = @id
                end
             */

            try
            {


                _command.CommandText = "sp_UpdateRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);
                _command.Parameters.AddWithValue("@passengerId", item.PassengerID);
                _command.Parameters.AddWithValue("@employeeId", item.EmployeeID);
                _command.Parameters.AddWithValue("@seatNumber", item.SeatNumber);
                _command.Parameters.AddWithValue("@tripId", item.TripID);
                _command.Parameters.AddWithValue("@price", item.Price);
                _command.Parameters.AddWithValue("@startCityId", item.StartCityID);
                _command.Parameters.AddWithValue("@endCityId", item.EndCityID);

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("TicketDataMapper Update metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }
    }
}
