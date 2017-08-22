using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TripPassengerDataMapper : IDataMapper<TripPassenger>
    {
        SqlCommand _command;

        public TripPassengerDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public TripPassenger Get(int key)
        {
            _command.CommandText = "Select TripID,PassengerID from TripPassenger where TripID=@TripId";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TripId", key);

            TripPassenger _tripPassenger = null;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _tripPassenger = new TripPassenger();
                        _tripPassenger.TripID = (int)reader["TripID"];
                        _tripPassenger.PassengerID = (int)reader["PassengerID"];
                    }
                }
                else
                {
                    throw new Exception("D001 : Bu id'ye ait bir kayıt bulunmamaktadır.");
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
            return _tripPassenger;
        }

        public List<TripPassenger> GetAll()
        {
            List<TripPassenger> tripPassengerList = new List<TripPassenger>();

            _command.CommandText = "Select TripID,PassengerID from TripPassenger";


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
                        TripPassenger _tripPassenger = new TripPassenger();

                        _tripPassenger.TripID = (int)reader["TripID"];
                        _tripPassenger.PassengerID = (int)reader["PassengerID"];

                        tripPassengerList.Add(_tripPassenger);
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
            
            return tripPassengerList;
        }

        public int Insert(TripPassenger item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into TripPassenger(TripID,PassengerID) values (@TripId,@passengerId)";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TripId", item.TripID);
            _command.Parameters.AddWithValue("@passengerId", item.PassengerID);

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

        public int Update(TripPassenger item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update TripPassenger set TripID=@tripId where TripID=@tripId";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tripId", item.TripID);
            _command.Parameters.AddWithValue("@passengerId", item.PassengerID);


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

        public int Delete(TripPassenger item)
        {
            int affectedRows = 0;



            _command.CommandText = "Delete from TripPassenger where TripID = @tripId";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tripId", item.TripID);


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
