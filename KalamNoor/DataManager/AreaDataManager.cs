﻿using KalamNoor.Models.Addresses;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class AreaDataManager
    {
        #region AreaMapper
        private static Area AreaMapper(IDataReader dataReader)
        {
            Area tempArea = new Area()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
                CityId = Convert.ToInt32(dataReader["CityId"].ToString()),
            };
            return tempArea;
        }
        #endregion

        #region PublicMethods
        public static List<Area> GetAreas()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[Areas]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Area> result = BaseDataManager.GetSPItems<Area>(sqlCommand, AreaMapper);
            return result;
        }
        public static int InsertArea(Area area)
        {
            if (area == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Areas](Name,CityId) " +
                                  "VALUES (@name,@cityId)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", area.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@cityId", area.CityId));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateArea(Area area)
        {

            if (area == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[Areas] SET " +
                                  "Name=@name,CityId=@cityId " +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", area.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", area.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@cityId", area.CityId));

            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        public static int DeleteArea(Area area)
        {
            if (area == null) return 0;
            //SQL Statement
            string sqlStatement = "DELETE FROM [dbo].[Areas] WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };


            sqlCommand.Parameters.Add(new SqlParameter("@id", area.ID));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        #endregion
    }
}
