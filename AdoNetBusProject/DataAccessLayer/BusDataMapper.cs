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
    public class BusDataMapper : IDataMapper<Bus>
    {
        SqlCommand cmd;
        public BusDataMapper()
        {
            cmd = SqlHelper.CreateSqlCommand();
        }
        public Bus Get(int key)
        {
            Bus bus = new Bus();
            cmd.CommandText = "select * from Bus where ID=@id";
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
                        bus.ID = (int)reader[0];
                        bus.ModelID = (int)reader["ModelID"];
                        bus.SeatCount = (int)reader["SeatCount"];
                        bus.TypeID = (int)reader["TypeID"];
                        bus.IsAvaliable = (bool)reader["IsAvaliable"];
                    }
                }
                else
                {
                    throw new Exception("A001: Bu id'ye ait otobüs yok.");
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
            return bus;
        }

        public List<Bus> GetAll()
        {
            List<Bus> lstBus = new List<Bus>();
            cmd.CommandText = "select * from Bus";
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
                        Bus bus = new Bus();
                        bus.ID = (int)reader[0];
                        bus.ModelID = (int)reader["ModelID"];
                        bus.SeatCount = (int)reader["SeatCount"];
                        bus.TypeID = (int)reader["TypeID"];
                        bus.IsAvaliable = (bool)reader["IsAvaliable"];
                        lstBus.Add(bus);
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
            return lstBus;
        }
        /// <summary>
        /// Girilen tarih değerleri arasında görevde olmayan otobüsleri getirir.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<Bus> GetAllBusByDate (DateTime startDate, DateTime endDate)
        {
            List<Bus> lstBus = new List<Bus>();
            /*
             create proc sp_GetAllBusByDate
                @startDate datetime,
                @endDate datetime
                as
                begin
	                select *
	                from
	                Bus except 
	                select b.* from
	                Bus b join Trip t on b.ID=t.BusID
	                join TripDetails td on td.TripID = t.ID
	                where (td.StartDate between @startDate and @endDate) 
	                or (td.EndDate between @startDate and @endDate)
	                or (td.StartDate < @startDate and td.EndDate>@endDate)	 
                end
             */
            cmd.CommandText = "sp_GetAllBusByDate";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@startDate", startDate);
            cmd.Parameters.Add("@endDate", endDate);
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
                        Bus bus = new Bus();
                        bus.ID = (int)reader[0];
                        bus.ModelID = (int)reader["ModelID"];
                        bus.SeatCount = (int)reader["SeatCount"];
                        bus.TypeID = (int)reader["TypeID"];
                        bus.IsAvaliable = (bool)reader["IsAvaliable"];
                        lstBus.Add(bus);
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
            return lstBus;
        }

        public int Insert(Bus item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Insert into Bus(ModelID,SeatCount,TypeID,IsAvaliable) values(@modelId, @SeatCount, @TypeId, @IsAvaible)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@modelId",item.ModelID);
            cmd.Parameters.AddWithValue("@SeatCount", item.SeatCount);
            cmd.Parameters.AddWithValue("@TypeId", item.TypeID);
            cmd.Parameters.AddWithValue("@IsAvaible",item.IsAvaliable);

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

        public int Update(Bus item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Update Bus set ModelID=@modelId, SeatCount=@seatCount, TypeID=@typeId, IsAvaliable=@IsAvaible where ID=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", item.ID);
            cmd.Parameters.AddWithValue("@modelId", item.ModelID);
            cmd.Parameters.AddWithValue("@seatCount", item.SeatCount);
            cmd.Parameters.AddWithValue("@typeId", item.TypeID);
            cmd.Parameters.AddWithValue("@IsAvaible",item.IsAvaliable);

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

        public int Delete(Bus item)
        {
            int affectedRows = 0;
            cmd.CommandText = "Delete from Bus where ID=@id";
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
