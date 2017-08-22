using BusCompanyClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RouteCitiesDataMapper : IDataMapper<RouteCities>
    {
        SqlCommand _command;

        public RouteCitiesDataMapper()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public List<RouteCities> GetAll()
        {
            /*  create proc sp_GetAllRouteCities
                as
                begin
                select RouteID,CityID from  RouteCities
                end
            */

            //TODO: Bu procedure SortIndex eklenmeli ya da * yazılmalı! (Atılay yazdı.) 

            List<RouteCities> routeList = new List<RouteCities>();
            _command.CommandText = "sp_GetAllRouteCities";
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
                            RouteCities routeCity = new RouteCities();
                            routeCity.RouteID = (int)reader[0];
                            routeCity.CityID = (int)reader[1];
                            routeCity.SortIndex = (int)reader[2];

                            routeList.Add(routeCity);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex + "\nRouteCitiesDataMapper GetAll metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return routeList;

        }
        /// <summary>
        /// Route' a ait ilk şehirin bilgilerini getirir.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public RouteCities Get(int key)
        {
            /*
                create proc sp_GetRouteCitiesByID
                @id int
                as
                begin
                select RouteID,CityID,SortIndex from RouteCities where RouteID = @id and SortIndex=1
                end
             */

            RouteCities routeCity = new RouteCities();
            _command.CommandText = "sp_GetRouteCitiesByID";
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
                            routeCity.RouteID = (int)reader[0];
                            routeCity.CityID = (int)reader[1];
                            routeCity.SortIndex = (int)reader[2];
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + "\nRouteCitiesDataMapper GetByID metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return routeCity;
        }
        /// <summary>
        /// Route' a ait ikinci şehrin bilgilerini getirir.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public RouteCities GetSecondCity(int key)
        {
            /*
               create proc sp_GetRouteSecondCityByID
				@id int
                as
                begin
                select RouteID,CityID,SortIndex from RouteCities where RouteID = @id and SortIndex=2
                end
             */

            RouteCities routeCity = new RouteCities();
            _command.CommandText = "sp_GetRouteSecondCityByID";
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
                            routeCity.RouteID = (int)reader[0];
                            routeCity.CityID = (int)reader[1];
                            routeCity.SortIndex = (int)reader[2];
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\nRouteCitiesDataMapper GetSecondCityByID metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return routeCity;
        }

        public int Delete(RouteCities item)
        {

            /*
                create proc sp_DeleteFromRouteCities
                @id int
                as
                begin
                delete from RouteCities where RouteID = @id
                end
             */
            int affecttedRows = 0;

            try
            {
                _command.CommandText = "sp_DeleteFromRouteCities";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@id", item.RouteID);

                affecttedRows = _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message+ "\nRouteCitiesDataMapper Delete Metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affecttedRows;

        }

        public int Insert(RouteCities item)
        {
            int affectedRows = 0;

            /*
                create proc sp_InsertIntoRouteCities
                @cityID int,
				@sortInd int
                as
                begin
                insert into RouteCities(RouteID,CityID,SortIndex) values(IDENT_CURRENT('Route'), @cityID,@sortInd)
                end
             */
            try
            {
                _command.CommandText = "sp_InsertIntoRouteCities";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@cityID", item.CityID);
                _command.Parameters.AddWithValue("@sortInd", item.SortIndex);

                affectedRows = _command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message+"\nRouteCitiesDataMapper Insert metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;


        }

        public int Update(RouteCities item)
        {
            int affectedRows = 0;

            /*  
                create proc sp_UpdateRouteCities
                @routeID int,
                @cityID int,
				@sortInd int
                as
                begin
                update RouteCities set CityID = @cityID, SortIndex=@sortInd where RouteID = @routeID
                end

             */

            try
            {
                _command.CommandText = "sp_UpdateRouteCities";
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@routeID", item.RouteID);
                _command.Parameters.AddWithValue("@cityID", item.CityID);
                _command.Parameters.AddWithValue("@sortInd", item.SortIndex);

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message+"\nRouteCitiesDataMapper Update metodunda hata oluştu.");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;

        }
    }
}
