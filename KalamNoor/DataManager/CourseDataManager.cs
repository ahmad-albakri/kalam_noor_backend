using KalamNoor.Models.Classes;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class CourseDataManager
    {
        #region Mappers
        private static Course CourseMapper(IDataReader dataReader)
        {
            Course tempCourse = new Course()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
                ClassId = Convert.ToInt32(dataReader["ClassId"].ToString()),
                TotalMark = Convert.ToInt32(dataReader["TotalMark"].ToString()),
                IsEnrichment = Convert.ToBoolean(dataReader["IsEnrichment"].ToString()),
            };
            return tempCourse;
        }
        #endregion

        #region PublicMethods
        public static List<Course> GetCourses()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[Courses]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Course> result = BaseDataManager.GetSPItems<Course>(sqlCommand, CourseMapper);
            return result;
        }
        public static int InsertCourse(Course course)
        {
            if (course == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Courses] (Name,ClassId,TotalMark,IsEnrichment) " +
                                  "VALUES (@name,@classId,@totalMark,@isEnrichment)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", course.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@classId", course.ClassId));
            sqlCommand.Parameters.Add(new SqlParameter("@totalMark", course.TotalMark));
            sqlCommand.Parameters.Add(new SqlParameter("@isEnrichment", course.IsEnrichment));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateCourse(Course course)
        {
            if (course == null) return 0;

            string sqlStatement = "UPDATE  [dbo].[Courses] SET " +
                                  "Name=@name,ClassId=@classId,TotalMark=@totalMark,IsEnrichment=@isEnrichment " +
                                  "WHERE ID=@id;";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", course.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", course.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@classId", course.ClassId));
            sqlCommand.Parameters.Add(new SqlParameter("@totalMark", course.TotalMark));
            sqlCommand.Parameters.Add(new SqlParameter("@isEnrichment", course.IsEnrichment));


            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeleteCourse(Course course)
        {
            if (course == null) return 0;

            string sqlStatement = "DELETE FROM [dbo].[Courses] WHERE ID=@id;";

            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };

            sqlCommand.Parameters.Add(new SqlParameter("@id", course.ID));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        #endregion

    }
}
