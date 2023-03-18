using KalamNoor.Models.Areas;
using KalamNoor.Models.MedicalRecords;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class MedicalRecordDataManager
    {
        #region Mapper
        private static MedicalRecord MedicalRecordMapper(IDataReader dataReader)
        {
            MedicalRecord tempMedicalRecord = new MedicalRecord()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                StudentId = Convert.ToInt32(dataReader["StudentId"].ToString()),
                VaccineId = Convert.ToInt32(dataReader["VaccineId"].ToString()),
                Note = dataReader["Note"].ToString(),
                
            };
            return tempMedicalRecord;
        }

        #endregion

        #region Public Methods
        public static List<MedicalRecord> GetMedicalRecords()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[MedicalRecord]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<MedicalRecord> result = BaseDataManager.GetSPItems<MedicalRecord>(sqlCommand, MedicalRecordMapper);
            return result;
        }
        public static int InsertMedicalRecord(MedicalRecord medicalRecord)
        {
            if (medicalRecord == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[MedicalRecord](StudentId,VaccineId,Note) " +
                                  "VALUES (@studentId,@vaccineId,@note)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@studentId", medicalRecord.StudentId));
            sqlCommand.Parameters.Add(new SqlParameter("@vaccineId", medicalRecord.VaccineId));
            sqlCommand.Parameters.Add(new SqlParameter("@note", medicalRecord.Note));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateMedicalRecord(MedicalRecord medicalRecord)
        {

            if (medicalRecord == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[MedicalRecord] SET " +
                                  "StudentId=@studentId,VaccineId=@vaccineId,Note=@note " +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@studentId", medicalRecord.StudentId));
            sqlCommand.Parameters.Add(new SqlParameter("@vaccineId", medicalRecord.VaccineId));
            sqlCommand.Parameters.Add(new SqlParameter("@note", medicalRecord.Note));


            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        public static int DeleteMedicalRecord(MedicalRecord medicalRecord)
        {
            if (medicalRecord == null) return 0;
            //SQL Statement
            string sqlStatement = "DELETE FROM [dbo].[MedicalRecord] WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };


            sqlCommand.Parameters.Add(new SqlParameter("@id", medicalRecord.ID));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        #endregion
    }
}
