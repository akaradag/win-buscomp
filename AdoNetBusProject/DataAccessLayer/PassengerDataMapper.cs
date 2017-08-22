using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PassengerDataMapper : IDataMapper<Passenger>
    {
        SqlCommand _command;

        public PassengerDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }


        public Passenger Get(int key)
        {
            Passenger passenger = new Passenger();

            _command.CommandText = "select ID,FirstName,LastName,SocialNumber,GenderID,Phone from Passenger where ID=@id";

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
                        passenger.ID = (int)reader["ID"];
                        passenger.FirstName= (string)reader["FirstName"];
                        passenger.LastName = (string)reader["LastName"];
                        passenger.SocialNumber = (decimal)reader["SocialNumber"];
                        passenger.GenderID=(int)reader["GenderID"];
                        passenger.Phone = (string)reader["Phone"];
                    }
                }
                else
                {
                    throw new Exception("B003 : Bu id'ye ait bir kayıt bulunmamaktadır.");
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

            return passenger;
        }

        public List<Passenger> GetAll()
        {

            List<Passenger> passengerList = new List<Passenger>();

            _command.CommandText = "select ID,FirstName,LastName,SocialNumber,GenderID,Phone from Passenger";


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
                        Passenger passenger = new Passenger();

                        passenger.ID = (int)reader["ID"];
                        passenger.FirstName = (string)reader["FirstName"];
                        passenger.LastName = (string)reader["LastName"];
                        passenger.SocialNumber = (decimal)reader["SocialNumber"];
                        passenger.GenderID = (int)reader["GenderID"];
                        passenger.Phone = (string)reader["Phone"];

                        passengerList.Add(passenger);
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

            return passengerList;
        }

        public int Insert(Passenger item)
        {

            int affectedRows = 0;

            _command.CommandText = "insert into Passenger(FirstName,LastName,SocialNumber,GenderID,Phone) values (@fName,@lName,@socialNum,@genderId,@phone)";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@fName", item.FirstName);
            _command.Parameters.AddWithValue("@lName", item.LastName);
            _command.Parameters.AddWithValue("@socialNum", item.SocialNumber);
            _command.Parameters.AddWithValue("@genderId", item.GenderID);
            _command.Parameters.AddWithValue("@phone", item.Phone);



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

        public int Update(Passenger item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update Passenger set FirstName=@name, LastName=@brand,SocialNumber=@socialNum,GenderID=@gederId,Phone=@phone  where ID =@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id",item.ID);
            _command.Parameters.AddWithValue("@fName", item.FirstName);
            _command.Parameters.AddWithValue("@lName", item.LastName);
            _command.Parameters.AddWithValue("@socialNum", item.SocialNumber);
            _command.Parameters.AddWithValue("@genderId", item.GenderID);
            _command.Parameters.AddWithValue("@phone", item.Phone);


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

        public int Delete(Passenger item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from Passenger where ID = @id";

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
