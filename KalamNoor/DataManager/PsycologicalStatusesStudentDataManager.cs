using KalamNoor.Models.Classes;
using KalamNoor.Models.PsychologicalStatus;
using KalamNoor.Models.Vaccines;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class PsycologicalStatusesStudentDataManager
    {
        #region Mappers
        private static PsychologicalStatusesStudent PsycologicalStatusesStudentMapper(IDataReader dataReader)
        {
            PsychologicalStatusesStudent tempPsycologicalStatusesStudent = new PsychologicalStatusesStudent()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                StudentId = Convert.ToInt32(dataReader["StudentId"].ToString()),
                PsychologicalStatusesId = Convert.ToInt32(dataReader["PsychologicalStatusesId"].ToString()),
                Notes = dataReader["Notes"].ToString()
            };
            return tempPsycologicalStatusesStudent;
        }
        #endregion

        #region PublicMethods
        public static List<PsychologicalStatusesStudent> GetPsycologicalStatusesStudents()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[PsychologicalStatusesStudent]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<PsychologicalStatusesStudent> result = BaseDataManager.GetSPItems<PsychologicalStatusesStudent>(sqlCommand, PsycologicalStatusesStudentMapper);
            return result;
        }

        public static int InsertPsycologicalStatusesStudent(PsychologicalStatusesStudent statusesStudent)
        {
            if (statusesStudent == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[PsychologicalStatusesStudent] (StudentId,PsychologicalStatusesId,Notes) " +
                                  "VALUES (@studentId,@psycologicalStatusesId,@notes)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@studentId", statusesStudent.StudentId));
            sqlCommand.Parameters.Add(new SqlParameter("@psycologicalStatusesId", statusesStudent.PsychologicalStatusesId));
            sqlCommand.Parameters.Add(new SqlParameter("@notes", statusesStudent.Notes));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdatePsycologicalStatusesStudent(PsychologicalStatusesStudent statusesStudent)
        {
            if (statusesStudent == null) return 0;

            string sqlStatement = "UPDATE  [dbo].[PsycologicalStatusesStudent] SET " +
                                  "StudentId=@studentId,PsychologicalStatusesId=@psycologicalStatusesId,Notes=@notes " +
                                  "WHERE ID=@id;";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", statusesStudent.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@studentId", statusesStudent.StudentId));
            sqlCommand.Parameters.Add(new SqlParameter("@psycologicalStatusesId", statusesStudent.PsychologicalStatusesId));
            sqlCommand.Parameters.Add(new SqlParameter("@notes", statusesStudent.Notes));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        public static int DeletePsycologicalStatusesStudent(PsychologicalStatusesStudent statusesStudent)
        {
            if (statusesStudent == null) return 0;

            string sqlStatement = "DELETE FROM [dbo].[PsycologicalStatusesStudent] WHERE ID=@id;";

            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };

            sqlCommand.Parameters.Add(new SqlParameter("@id", statusesStudent.ID));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        #endregion
    }
}
