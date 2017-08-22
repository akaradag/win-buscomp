using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class RoleDataMapper : IDataMapper<Role>
    {
        SqlCommand _command;

        public RoleDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Role Get(int key)
        {
            Role role = new Role();

            _command.CommandText = "Select ID,Name from Role where ID=@id";

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
                        role.ID = (int)reader["ID"];
                        role.Name = reader.GetString(1);
                        
                    }
                }
                else
                {
                    throw new Exception("B005 : Bu id'ye ait bir kayıt bulunmamaktadır.");
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

            return role;
        }

        public List<Role> GetAll()
        {
            List<Role> roleList = new List<Role>();

            _command.CommandText = "select ID,Name from Role";


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
                        Role role = new Role();

                        role.ID = (int)reader["ID"];
                        role.Name = reader.GetString(1);
                       
                        roleList.Add(role);
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

            return roleList;
        }

        public int Insert(Role item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into Role(Name) values (@name)";

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

        public int Update(Role item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update Role set Name=@name where ID =@id";

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

        public int Delete(Role item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from Role where ID = @id";

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
