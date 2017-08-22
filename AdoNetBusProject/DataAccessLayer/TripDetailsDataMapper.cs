using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TripDetailsDataMapper : IDataMapper<TripDetails>
    {
        SqlCommand _command;

        public TripDetailsDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public TripDetails Get(int key)
        {
            _command.CommandText = "Select * from TripDetails where TripID=@tripId";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tripId", key);

            TripDetails _tripDetails=null;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _tripDetails = new TripDetails();
                        _tripDetails.TripID = (int)reader["TripID"];
                        _tripDetails.RouteID = (int)reader["RouteID"];
                        _tripDetails.HourID = (int)reader["HourID"];
                        _tripDetails.StartDate = (DateTime)reader["StartDate"];
                        _tripDetails.EndDate = (DateTime)reader["EndDate"];
                        _tripDetails.PredictedTime = reader["PredictedTime"].ToString();
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
            return _tripDetails;
        }

        public List<TripDetails> GetAll()
        {
            List<TripDetails> tripDetailsList = new List<TripDetails>();

            _command.CommandText = "Select * from TripDetails";


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
                        TripDetails _tripDetails = new TripDetails();
                        _tripDetails.TripID = (int)reader["TripID"];
                        _tripDetails.RouteID = (int)reader["RouteID"];
                        _tripDetails.HourID = (int)reader["HourID"];
                        _tripDetails.StartDate = (DateTime)reader["StartDate"];
                        _tripDetails.EndDate = (DateTime)reader["EndDate"];
                        _tripDetails.PredictedTime = reader["PredictedTime"].ToString();

                        tripDetailsList.Add(_tripDetails);
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

            return tripDetailsList;
        }
        public List<TripDetails> GetAllwDetails()
        {
            List<TripDetails> tripDetailsList = new List<TripDetails>();

            _command.CommandText = "Select * from TripDetails td join Trip t on t.ID=td.TripID join Route r on r.ID=td.RouteID";


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
                        TripDetails _tripDetails = new TripDetails();
                        _tripDetails.TripID = (int)reader["TripID"];
                        _tripDetails.RouteID = (int)reader["RouteID"];
                        _tripDetails.HourID = (int)reader["HourID"];
                        _tripDetails.StartDate = (DateTime)reader["StartDate"];
                        _tripDetails.EndDate = (DateTime)reader["EndDate"];
                        _tripDetails.PredictedTime = reader["PredictedTime"].ToString();
                        _tripDetails.Route.Name = reader["Name"].ToString();
                        _tripDetails.Route.Price = (decimal)reader["Price"];
                        _tripDetails.Trip.BusID = (int)reader["BusID"];

                        tripDetailsList.Add(_tripDetails);
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

            return tripDetailsList;
        }

        public int Insert(TripDetails item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into TripDetails(TripID,RouteID,HourID,StartDate,EndDate,PredictedTime) values (IDENT_CURRENT('Trip'),@routeId,@hourId,@startDate,@endDate,@predictedTime)";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@routeId", item.RouteID);
            _command.Parameters.AddWithValue("@hourId", item.HourID);
            _command.Parameters.AddWithValue("@startDate", item.StartDate);
            _command.Parameters.AddWithValue("@endDate", item.EndDate);
            _command.Parameters.AddWithValue("@predictedTime", item.PredictedTime);

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

        public int Update(TripDetails item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update TripDetails set TripID=@tripId,RouteID=@routeId,HourID=@hourId,StartDate=@startDate,EndDate=@endDate, PredictedTime=@predictedTime where TripID=@tripId";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tripId", item.TripID);
            _command.Parameters.AddWithValue("@routeId", item.RouteID);
            _command.Parameters.AddWithValue("@hourId", item.HourID);
            _command.Parameters.AddWithValue("@startDate", item.StartDate);
            _command.Parameters.AddWithValue("@endDate", item.EndDate);
            _command.Parameters.AddWithValue("@predictedTime", item.PredictedTime);

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

        public int Delete(TripDetails item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from TripDetails where TripID = @tripId";

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
