using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusCompanyClassLibrary;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class BrandDataMapper : IDataMapper<Brand>
    {
        SqlCommand cmd;
        public BrandDataMapper()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }

        public Brand Get(int key)
        {
            Brand brand = new Brand();
            cmd.CommandText = "select * from Brand where ID=@id";
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
                        brand.ID = (int)reader[0];
                        brand.Name = reader[1].ToString();
                    }
                }
                else
                {
                    throw new Exception("A001: Bu id'ye ait Marka yok.");
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
            return brand;
        }

        public List<Brand> GetAll()
        {
            List<Brand> lstBrand = new List<Brand>();
            cmd.CommandText = "select * from Brand";
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
                        Brand brand = new Brand();
                        brand.ID = (int)reader[0];
                        brand.Name = reader[1].ToString();
                        lstBrand.Add(brand);
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
            return lstBrand;
        }

        public int Insert(Brand item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Insert into Brand (Name) values(@name)";
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

        public int Update(Brand item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Update Brand set Name=@name where ID=@id";
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

        public int Delete(Brand item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Delete from Brand where ID=@id";
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
