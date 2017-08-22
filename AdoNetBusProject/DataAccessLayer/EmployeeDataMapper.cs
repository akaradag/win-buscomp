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
    public class EmployeeDataMapper : IDataMapper<Employee>
    {
        SqlCommand cmd;
        public EmployeeDataMapper()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }


        public Employee Get(int key)
        {
            Employee emp = new Employee();
            cmd.CommandText = "select * from Employee where ID=@id";
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
                        emp.FirstName = reader["FirstName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.Address = reader["Address"].ToString();
                        emp.BirthDate = (DateTime)reader["BirthDate"];
                        emp.CityID = (int)reader["CityID"];
                        emp.GenderID = (int)reader["GenderID"];
                        emp.HireDate = (DateTime)reader["HireDate"];
                        emp.ID = (int)reader[0];
                        emp.Mail = reader["Mail"].ToString();
                        emp.Password = reader["Password"].ToString();
                        emp.Phone = reader["Phone"].ToString();
                        emp.RoleID = (int)reader["RoleID"];
                        emp.IsAvaliable = (bool)reader["IsAvaliable"];
                    }
                }
                else
                {
                    throw new Exception("A001: Bu id'ye ait çalışan yok.");
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
            return emp;
        }

        public List<Employee> GetAll()
        {
            List<Employee> lstEmployee = new List<Employee>();
            cmd.CommandText = "select * from Employee";
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
                        Employee emp = new Employee();
                        emp.FirstName = (string)reader["FirstName"];
                        emp.LastName = (string)reader["LastName"];
                        emp.Address = (string)reader["Address"];
                        emp.BirthDate = (DateTime)reader["BirthDate"];
                        emp.CityID = (int)reader["CityID"];
                        emp.GenderID = (int)reader["GenderID"];
                        emp.HireDate = (DateTime)reader["HireDate"];
                        emp.ID = (int)reader[0];
                        emp.Mail = (string)reader["Mail"];
                        emp.Password = (string)reader["Password"];
                        emp.Phone = (string)reader["Phone"];
                        emp.RoleID = (int)reader["RoleID"];
                        emp.IsAvaliable = (bool)reader["IsAvaliable"];

                        lstEmployee.Add(emp);
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
            return lstEmployee;
        }

        public List<Employee> GetAllEmpByDate(DateTime startDate,DateTime endDate)
        {
            List<Employee> lstEmployee = new List<Employee>();
            /*
            alter proc sp_GetAllBusEmpByDate
            @startDate datetime,
            @endDate datetime
            as
            begin
	            select * from Employee except
	            select e.* from Employee e join TripEmployee te on te.EmployeeID=e.ID
	            join Trip t on t.ID = te.TripID join TripDetails td on td.TripID=t.ID
	            where (td.StartDate between @startDate and @endDate) 
	            or (td.EndDate between @startDate and @endDate)
	            or (td.StartDate < @startDate and td.EndDate>@endDate)
	            or e.IsAvaliable = 0
            end
             */
            cmd.CommandText = "sp_GetAllBusEmpByDate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);
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
                        Employee emp = new Employee();
                        emp.FirstName = reader["FirstName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.Address = reader["Address"].ToString();
                        emp.BirthDate = (DateTime)reader["BirthDate"];
                        emp.CityID = (int)reader["CityID"];
                        emp.GenderID = (int)reader["GenderID"];
                        emp.HireDate = (DateTime)reader["HireDate"];
                        emp.ID = (int)reader[0];
                        emp.Mail = reader["Mail"].ToString();
                        emp.Password = reader["Password"].ToString();
                        emp.Phone = reader["Phone"].ToString();
                        emp.RoleID = (int)reader["RoleID"];
                        emp.IsAvaliable = (bool)reader["IsAvaliable"];

                        lstEmployee.Add(emp);
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
            return lstEmployee;
        }

        public int Insert(Employee item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Insert into Employee(FirstName,LastName,Address,BirthDate,CityID,GenderID,HireDate,Mail,Password,Phone,RoleID,IsAvaliable) values(@firstName,@lastName,@address,@birthDate,@cityID,@genderID,@hireDate,@mail,@password,@phone,@roleId,@isAvaliable)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@firstName", item.FirstName);
            cmd.Parameters.AddWithValue("@lastName", item.LastName);
            cmd.Parameters.AddWithValue("@address", item.Address);
            cmd.Parameters.AddWithValue("@birthDate", item.BirthDate);
            cmd.Parameters.AddWithValue("@cityID", item.CityID);
            cmd.Parameters.AddWithValue("@genderID", item.GenderID);
            cmd.Parameters.AddWithValue("@hireDate", item.HireDate);
            cmd.Parameters.AddWithValue("@mail", item.Mail);
            cmd.Parameters.AddWithValue("@password", item.Password);
            cmd.Parameters.AddWithValue("@phone", item.Phone);
            cmd.Parameters.AddWithValue("@roleId", item.RoleID);
            cmd.Parameters.AddWithValue("@isAvaliable", item.IsAvaliable);
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

        public int Update(Employee item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Update Employee set FirstName=@firstName, LastName=@lastName, Address=@address, BirthDate=@birthDate, CityID=@cityID, GenderID=@genderID, HireDate=@hireDate, Mail=@mail, Password=@password, Phone=@phone, RoleID=@roleId, IsAvaliable=@isAvaliable where ID=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", item.ID);
            cmd.Parameters.AddWithValue("@firstName", item.FirstName);
            cmd.Parameters.AddWithValue("@lastName", item.LastName);
            cmd.Parameters.AddWithValue("@address", item.Address);
            cmd.Parameters.AddWithValue("@birthDate", item.BirthDate);
            cmd.Parameters.AddWithValue("@cityID", item.CityID);
            cmd.Parameters.AddWithValue("@genderID", item.GenderID);
            cmd.Parameters.AddWithValue("@hireDate", item.HireDate);
            cmd.Parameters.AddWithValue("@mail", item.Mail);
            cmd.Parameters.AddWithValue("@password", item.Password);
            cmd.Parameters.AddWithValue("@phone", item.Phone);
            cmd.Parameters.AddWithValue("@roleId", item.RoleID);
            cmd.Parameters.AddWithValue("@isAvaliable", item.IsAvaliable);

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

        public int Delete(Employee item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Delete from Employee where ID=@id";
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
