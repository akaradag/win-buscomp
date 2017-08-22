using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BusTypeDataMapper : IDataMapper<BusType>
    {
        SqlCommand _command;

        public BusTypeDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public BusType Get(int key)
        {
            _command.CommandText = "Select ID,Name from [Type] where ID=@id";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", key);

            BusType _busType = null;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _busType = new BusType();
                        _busType.ID = (int)reader["ID"];
                        _busType.Name = reader.GetString(1);
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
            return _busType;
        }

        public List<BusType> GetAll()
        {
            List<BusType> busTypeList = new List<BusType>();

            _command.CommandText = "Select ID,Name from [Type]";


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
                        BusType _busType = new BusType();

                        _busType.ID = (int)reader["ID"];
                        _busType.Name = reader.GetString(1);

                        busTypeList.Add(_busType);
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

            return busTypeList;
        }

        public int Insert(BusType item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into [Type](Name) values (@name)";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@name", item.Name);            

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

        public int Update(BusType item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update [Type] set Name=@name where ID=@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);
            _command.Parameters.AddWithValue("@name", item.Name);


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

        public int Delete(BusType item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from [Type] where ID = @id";

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
