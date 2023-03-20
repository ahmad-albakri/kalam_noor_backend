using KalamNoor.Models.PreviousSchools;
using KalamNoor.Models.PsycologicalSataus;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class PsychologicalStatusDataManager
    {
        #region Mapper
        private static PsychologicalStatus PsychologicalStatusMapper(IDataReader dataReader)
        {
            PsychologicalStatus tempPsychologicalStatus = new PsychologicalStatus()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
                Details = dataReader["Details"].ToString(),
            };
            return tempPsychologicalStatus;
        }
        #endregion

        #region PublicMethods
        public static List<PsychologicalStatus> GetPsychologicalStatuss()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[PsychologicalStatuss]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<PsychologicalStatus> result = BaseDataManager.GetSPItems<PsychologicalStatus>(sqlCommand, PsychologicalStatusMapper);
            return result;
        }
        public static int InsertPsychologicalStatus(PsychologicalStatus psychological)

        {
            if (psychological == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[PsychologicalStatuss](Name,Details) " +
                                  "VALUES (@name,@details)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", psychological.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@details", psychological.Details));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdatePsychologicalStatus(PsychologicalStatus psychological)
        {

            if (psychological == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[PsychologicalStatuss] SET " +
                                  "Name=@name,Details=@details " +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", psychological.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", psychological.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@details", psychological.Details));

            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeletePsychologicalStatus(PsychologicalStatus psychological)
        {
            if (psychological == null) return 0;
            //SQL Statement
            string sqlStatement = "DELETE FROM [dbo].[PsychologicalStatuss] WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };


            sqlCommand.Parameters.Add(new SqlParameter("@id", psychological.ID));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        #endregion
    }
}
