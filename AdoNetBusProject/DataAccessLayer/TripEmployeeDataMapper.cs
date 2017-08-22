using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TripEmployeeDataMapper : IDataMapper<TripEmployee>
    {
        SqlCommand _command;

        public TripEmployeeDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        
        public TripEmployee Get(int key)
        {
            _command.CommandText = "Select TripID,EmployeeID from TripEmployee where TripID=@tripId";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tripId", key);

            TripEmployee _tripEmployee = null;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _tripEmployee = new TripEmployee();
                        _tripEmployee.TripID = (int)reader["TripID"];
                        _tripEmployee.EmployeeID = (int)reader["EmployeeID"];
                        
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
            return _tripEmployee;
        }

        public List<TripEmployee> GetAll()
        {
            List<TripEmployee> tripEmployeeList = new List<TripEmployee>();

            _command.CommandText = "Select TripID,EmployeeID from TripEmployee";


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
                        TripEmployee _tripEmployee = new TripEmployee();
                        _tripEmployee.TripID = (int)reader["TripID"];
                        _tripEmployee.EmployeeID = (int)reader["EmployeeID"];


                        tripEmployeeList.Add(_tripEmployee);
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

            return tripEmployeeList;
        }

        public int Insert(TripEmployee item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into TripEmployee(TripID,EmployeeID) values (IDENT_CURRENT('Trip'),@employeeId)";
            
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@employeeId", item.EmployeeID);
            

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

        public int Update(TripEmployee item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update TripEmployee set TripID=@tripId,EmployeeID=@employeeId where TripID=@tripId";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tripId", item.TripID);
            _command.Parameters.AddWithValue("@employeeId", item.EmployeeID);
            
            
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

        public int Delete(TripEmployee item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from TripEmployee where TripID = @tripId";

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
