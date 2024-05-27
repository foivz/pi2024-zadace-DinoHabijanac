using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            int line = int.Parse(reader["Line"].ToString());
            string schedule = reader["Schedule"].ToString();
            var station = new Station
            {
                Id = id,
                Name = name,
                Description = description,
                Line = line,
                Schedule = schedule
            };
            return station;
        }
        public static Station GetStation(int id)
        {
            Station station = null;
            string sql = $"SELECT * FROM dbo.Stations WHERE Id = {id}";
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
            string sql = "SELECT * FROM dbo.Stations";
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

        public static void DeleteEvaluation(int id)
        {
            string sql = $"DELETE FROM dbo.Stations WHERE Id = {id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void InsertEvaluation(Station station)
        {

            string sql = $"INSERT INTO dbo.Stations (Id,Name,Description,Line,Schedule) VALUES ({station.Id},'{station.Name}','{station.Description}',{station.Line},'{station.Schedule}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            
        }

        public static void UpdateEvaluation(Station station)
        {

            string sql = $"UPDATE dbo.Stations SET Name='{station.Name}',Description='{station.Description}',Line={station.Line},Schedule='{station.Schedule}' WHERE Id={station.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
