using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ModelDataMapper : IDataMapper<Model>
    {
        SqlCommand _command;

        public ModelDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }


        public Model Get(int key)
        {
            Model model = new Model();

            _command.CommandText = "select ID,Name,BrandID from Model where ID=@id";

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
                        model.ID = (int)reader["ID"];
                        model.Name = reader.GetString(1);
                        model.BrandID = (int)reader["BrandID"];
                    }
                }
                else
                {
                    throw new Exception("B002 : Bu id'ye ait bir kayıt bulunmamaktadır.");
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

            return model;
        }

        public List<Model> GetAll()
        {
            List<Model> modelList = new List<Model>();

            _command.CommandText = "select ID,Name,BrandID from Model";



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
                        Model model = new Model();

                        model.ID = (int)reader["ID"];
                        model.Name = reader.GetString(1);
                        model.BrandID = (int)reader["BrandID"];

                        modelList.Add(model);
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

            return modelList;


        }

        public int Insert(Model item)
        {
            int affectedRows = 0;

            _command.CommandText = "insert into Model(Name,BrandID) values (@name,@brand)";

            _command.Parameters.Clear();

            _command.Parameters.AddWithValue("@name", item.Name);
            _command.Parameters.AddWithValue("@brand", item.BrandID);



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

        public int Update(Model item)
        {
            int affectedRows = 0;

            _command.CommandText = "Update Model set Name=@name, BrandID=@brand where ID =@id";

            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", item.ID);
            _command.Parameters.AddWithValue("@name", item.Name);
            _command.Parameters.AddWithValue("@brand", item.BrandID);


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

        public int Delete(Model item)
        {
            int affectedRows = 0;

            _command.CommandText = "Delete from Model where ID = @id";

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
