using KalamNoor.Models.Classes;
using KalamNoor.Models.Vaccines;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class VaccineDataManager
    {
        #region Mapper
        private static Vaccine VaccineMapper(IDataReader dataReader)
        {
            Vaccine tempVaccine = new Vaccine()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
            };
            return tempVaccine;
        }

        #endregion

        #region Public Methods

        public static List<Vaccine> GetVaccines()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[Vaccines]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Vaccine> result = BaseDataManager.GetSPItems<Vaccine>(sqlCommand, VaccineMapper);
            return result;
        }
        public static int InsertVaccine(Vaccine vaccine)
        {
            if (vaccine == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Vaccines] (Name) " +
                                  "VALUES (@name)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", vaccine.Name));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateVaccine(Vaccine vaccine)
        {
            if (vaccine == null) return 0;

            string sqlStatement = "UPDATE  [dbo].[Vaccines] SET " +
                                  "Name=@name " +
                                  "WHERE ID=@id;";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };

            sqlCommand.Parameters.Add(new SqlParameter("@id", vaccine.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", vaccine.Name));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeleteVaccine(Vaccine vaccine)
        {
            if (vaccine == null) return 0;

            string sqlStatement = "DELETE FROM [dbo].[Vaccines] WHERE ID=@id;";

            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };

            sqlCommand.Parameters.Add(new SqlParameter("@id", vaccine.ID));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        #endregion
    }
}
