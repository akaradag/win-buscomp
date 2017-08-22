using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TripDataMapper : IDataMapper<Trip>
    {
        SqlCommand _command;

        public TripDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Trip Get(int key)
        {
            _command.CommandText = "Select ID,BusID from Trip where ID=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", key);

            Trip _trip = null;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _trip = new Trip();
                        _trip.ID = (int)reader["ID"];
                        _trip.BusID = (int)reader["BusID"]; 
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
            return _trip;
        }

        public List<Trip> GetAll()
        {
            List<Trip> tripList = new List<Trip>();

            _command.CommandText = "Select ID,BusID from Trip";


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
                        Trip _trip = new Trip();

                        _trip.ID = (int)reader["ID"];
                        _trip.BusID = (int)reader["BusID"];

                        tripList.Add(_trip);
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

            return tripList;
        }

        public int Insert(Trip item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into Trip(ID,BusID) values (@id,@busId)";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);
            _command.Parameters.AddWithValue("@busId", item.BusID);

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

        public int Update(Trip item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update Trip set ID=@id,BusID=@busId where ID=@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);
            _command.Parameters.AddWithValue("@busId", item.BusID);


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

        public int Delete(Trip item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from Trip where ID = @id";

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
