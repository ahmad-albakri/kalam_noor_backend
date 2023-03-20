using KalamNoor.Models.Addresses;
using KalamNoor.Models.YearsRecords;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class YearReccordDataManager
    {
        #region Mappers
        private static YearRecord YearRecordMapper(IDataReader dataReader)
        {
            YearRecord tempYearRecord = new YearRecord()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                YearOfRecord = Convert.ToInt32(dataReader["YearOfReccord"].ToString()),
                StudentId = Convert.ToInt32(dataReader["StudentId"].ToString()),
                ClassRoomId = Convert.ToInt32(dataReader["ClassRoomId"].ToString()),
                FirstSemesterId = Convert.ToInt32(dataReader["FirstSemesterId"].ToString()),
                SecondSemesterId = Convert.ToInt32(dataReader["SecondSemesterId"].ToString()),
            };
            return tempYearRecord;
        }
        #endregion

        #region PublicMethod

        public static List<YearRecord> GetYearRecords()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[YearReccords]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<YearRecord> result = BaseDataManager.GetSPItems<YearRecord>(sqlCommand, YearRecordMapper);
            return result;
        }

        public static int InsertYearReccord(YearRecord yearRecord)
        {
            if (yearRecord == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[YearRecords](YearOfReccord,StudentId,ClassRoomId," +
                                  "FirstSemesterId,SecondSemesterId) " +
                                  "VALUES (@yearOfReccord,@studentId,@classRoomId,@firstSemesterId,@secondSemesterId)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@yearOfReccord", yearRecord.YearOfRecord));
            sqlCommand.Parameters.Add(new SqlParameter("@studentId", yearRecord.StudentId));
            sqlCommand.Parameters.Add(new SqlParameter("@classRoomId", yearRecord.ClassRoomId));
            sqlCommand.Parameters.Add(new SqlParameter("@firstSemesterId", yearRecord.FirstSemesterId));
            sqlCommand.Parameters.Add(new SqlParameter("@secondSemesterId", yearRecord.SecondSemesterId));


            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateYearReccord(YearRecord yearRecord)
        {
            if (yearRecord == null) return 0;

            string sqlStatement = "UPDATE[dbo].[YearRecords] SET " +
                                  "YearOfReccord=@yearOfReccord,StudentId=@studentId,ClassRoomId=@classRoomId," +
                                  "FirstSemesterId=@firstSemesterId,SecondSemesterId=@secondSemesterId " +
                                  "WHERE ID=@id;";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", yearRecord.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@yearOfReccord", yearRecord.YearOfRecord));
            sqlCommand.Parameters.Add(new SqlParameter("@studentId", yearRecord.StudentId));
            sqlCommand.Parameters.Add(new SqlParameter("@classRoomId", yearRecord.ClassRoomId));
            sqlCommand.Parameters.Add(new SqlParameter("@firstSemesterId", yearRecord.FirstSemesterId));
            sqlCommand.Parameters.Add(new SqlParameter("@secondSemesterId", yearRecord.SecondSemesterId));


            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }


        #endregion
    }
}
