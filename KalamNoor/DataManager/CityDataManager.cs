using System.Data;
using System.Data.SqlClient;
using KalamNoor.Models.Addresses;

namespace KalamNoor.DataManager
{
    public abstract class CityDataManager
    {
        #region Mappers
        private static City CityMapper(IDataReader dataReader)
        {
            City tempCity = new City()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
            };
            return tempCity;
        }
        #endregion
       
       // #region Public Methods
        public static List<City> GetCities()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[Cities]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<City> result = BaseDataManager.GetSPItems<City>(sqlCommand, CityMapper);
            return result;
        }
        public static int InsertCity(City city)
        {
            if (city == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Cities] (Name) " +
                                  "VALUES (@name)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", city.Name));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateCity(City city)
        {
            if (city == null) return 0;

            string sqlStatement = "UPDATE  [dbo].[Cities] SET " +
                                  "Name=@name " +
                                  "WHERE ID=@id;";

            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", city.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", city.Name));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeleteCity(City city)
        {
            if (city == null) return 0;

            string sqlStatement = "DELETE FROM [dbo].[Cities] WHERE ID=@id;";

            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", city.ID));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

    }
}