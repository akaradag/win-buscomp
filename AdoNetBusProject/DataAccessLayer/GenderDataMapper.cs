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
    public class GenderDataMapper
    {
        SqlCommand cmd;
        public GenderDataMapper()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }
        

        public Gender Get(int key)
        {
            Gender gender = new Gender();
            
            cmd.CommandText = "select * from Gender where ID=@id";
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
                       gender.ID  = (int)reader[0];
                        gender.Name= reader[1].ToString();
                    }
                }
                else
                {
                    throw new Exception("A001: Bu id'ye ait cinsiyet yok.");
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

            return gender;
        }
        public List<Gender> GetAll()
        {
            List<Gender> lstGender = new List<Gender>();

            cmd.CommandText = "select * from Gender";
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
                        Gender gender = new Gender();                            
                         gender.ID =   (int)reader[0];
                        gender.Name= reader[1].ToString();
                        lstGender.Add(gender);
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

            return lstGender;
        }
    }
}
