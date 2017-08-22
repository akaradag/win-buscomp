using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class HourDataMapper : IDataMapper<Hour>
    {
        SqlCommand _command;

        public HourDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Hour Get(int key)
        {
            Hour hour = new Hour();

            _command.CommandText = "Select ID,DepartureTime from Hour where ID=@id";

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
                        hour.ID = (int)reader["ID"];
                        hour.DepartureTime = reader["DepartureTime"].ToString();

                    }
                }
                else
                {
                    throw new Exception("B001 : Bu id'ye ait bir kayıt bulunmamaktadır.");
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
            return hour;
        }

        public List<Hour> GetAll()
        {
            List<Hour> hourList = new List<Hour>();

            _command.CommandText = "Select ID,DepartureTime from Hour";

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
                        Hour hour = new Hour();


                        hour.ID = (int)reader["ID"];
                        hour.DepartureTime = reader["DepartureTime"].ToString();

                        hourList.Add(hour);
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


            return hourList;
        }

        public int Delete(Hour item)
        {
            int affectedRows = 0;



            _command.CommandText = "Delete from Hour where ID = @id";

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

        public int Insert(Hour item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into Hour(DepartureTime) values (@departuretime)";

            _command.Parameters.Clear();
            
            _command.Parameters.AddWithValue("@departuretime", item.DepartureTime);

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

        public int Update(Hour item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update Hour set DepartureTime=@departuretime where ID =@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);
            _command.Parameters.AddWithValue("@departuretime", item.DepartureTime);


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
