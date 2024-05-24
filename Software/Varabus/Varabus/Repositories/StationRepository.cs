using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Varabus.Models;

namespace Varabus.Repositories
{
    internal class StationRepository
    {
        private static Station CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            var station = new Station
            {
                Id = id,
                Name = name,
                Description = description
            };
            return station;
        }
        public static Station GetStation(int id)
        {
            Station station = null;
            string sql = $"SELECT * FROM Stations WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                station = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return station;
        }

        public static List<Station> GetStations()
        {
            List<Station> stations = new List<Station>();
            string sql = "SELECT * FROM Stations";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Station station = CreateObject(reader);
                stations.Add(station);
            }
            reader.Close();
            DB.CloseConnection();
            return stations;
        }
    }
}
