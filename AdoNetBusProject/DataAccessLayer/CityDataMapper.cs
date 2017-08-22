using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class CityDataMapper:IDataMapper<City>
    {
        SqlCommand cmd;
        public CityDataMapper()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }


        public City Get(int key)
        {
            City city = new City();
            cmd.CommandText = "select * from City where ID=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", key);
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        city.ID = (int)reader[0];
                        city.Name = reader[1].ToString();
                    }
                }
                else
                {
                    throw new Exception("A001: Bu id'ye ait Şehir yok.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return city;
        }

        public List<City> GetAll()
        {
            List<City> lstCity = new List<City>();
            cmd.CommandText = "select * from City";
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        City city = new City();
                        city.ID = (int)reader[0];
                        city.Name = reader[1].ToString();
                        lstCity.Add(city);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lstCity;
        }

        public int Insert(City item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Insert into City(Name) values(@name)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", item.Name);
            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return affectedRows;
        }

        public int Update(City item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Update City set Name=@name where ID=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", item.ID);
            cmd.Parameters.AddWithValue("@name", item.Name);

            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return affectedRows;
        }

        public int Delete(City item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Delete from City where ID=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", item.ID);

            try
            {
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return affectedRows;
        }
    }
}
