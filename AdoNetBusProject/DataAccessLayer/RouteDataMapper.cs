using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RouteDataMapper : IDataMapper<Route>
    {
        SqlCommand _command;

        public RouteDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        public List<Route> GetAll()
        {
            /*
             *  create proc sp_GetAllRoute
                as
                begin
                select ID, Name, Price from  Route
                end
             */
            List<Route> routeList = new List<Route>();
            _command.CommandText = "sp_GetAllRoute";
            _command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                    SqlDataReader reader = _command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Route route = new Route();
                            route.ID = (int)reader[0];
                            route.Name = (string)reader[1];
                            route.Price = (decimal)reader[2];

                            routeList.Add(route);
                        }
                    }


                }
            }
            catch (Exception)
            {
                throw new Exception("RouteDataMapper GetAll metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return routeList;
        }

        public Route Get(int key)
        {
            /*
            alter proc sp_GetRouteByID
                @id int
                as
                begin
                select * from [Route] where ID = @id
                end

             */

            Route route = new Route();
            _command.CommandText = "sp_GetRouteByID";
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", key);

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            route.ID = (int)reader[0];
                            route.Name = (string)reader["Name"];
                            route.Price = (decimal)reader["Price"];
                        }
                    }

                }
            }
            catch
            {
                throw new Exception("RouteDataMapper GetByID metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return route;
        }

        public int Delete(Route item)
        {
            int affecttedRows = 0;

            /*
                create proc sp_DeleteFromRoute
                @id int
                as
                begin
                delete from [Route] where ID = @id
                end
             */

            try
            {
                _command.CommandText = "sp_DeleteFromRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);

                affecttedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("RouteDataMapper Delete Metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affecttedRows;
        }

        public int Insert(Route item)
        {
            int affectedRows = 0;
            /*
                create proc sp_InsertIntoRoute
                @name nvarchar(50),
                @price decimal(5,2)
                as
                begin
                insert into Route(Name,Price) values(@name,@price)
                end
             */

            try
            {
                _command.CommandText = "sp_InsertIntoRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);
                _command.Parameters.AddWithValue("@name", item.Name);
                _command.Parameters.AddWithValue("@price", item.Price);

                affectedRows = _command.ExecuteNonQuery();
            }

            catch
            {
                throw new Exception("RouteDataMapper Insert metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

        public int Update(Route item)
        {
            int affectedRows = 0;

            /*
             *  create proc sp_UpdateRoute
                @id int,
                @name nvarchar(50),
                @price decimal(5,2)
                as
                begin
                update Route set Name = @name, Price = @price where ID = @id
                end
             */

            try
            {


                _command.CommandText = "sp_UpdateRoute";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.ID);
                _command.Parameters.AddWithValue("@name", item.Name);
                _command.Parameters.AddWithValue("@price", item.Price);

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception("RouteDataMapper Update metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }
    }
}
