using System.Data;
using System.Data.SqlClient;
using KalamNoor.Models.Students;

namespace KalamNoor.DataManager
{
    public abstract class StudentDataManager
    {
        #region Student Mapper
        private static Student StudentMapper(IDataReader dataReader)
        {
            Student tempStudent = new Student()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                FirstName = dataReader["FirstName"].ToString(),
                IsMale = Convert.ToBoolean(dataReader["IsMale"].ToString()),
                DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"].ToString()),
                PlaceOfBirth = dataReader["PlaceOfBirth"].ToString(),
                MobilePhoneNumber = dataReader["MobilePhoneNumber"].ToString(),
                WhatsAppPhoneNumber = dataReader["WhatsAppPhoneNumber"].ToString(),
                LandLine = dataReader["LandLine"].ToString(),
                AddressId = Convert.ToInt32(dataReader["AddressId"].ToString()),
                JoinDate = Convert.ToDateTime(dataReader["JoinDate"].ToString()),
                LeaveDate = Convert.ToDateTime(dataReader["LeaveDate"].ToString()),
                FatherId = Convert.ToInt32(dataReader["FatherId"].ToString()),
                MotherId = Convert.ToInt32(dataReader["MotherId"].ToString()),
                PreviousSchoolId = Convert.ToInt32(dataReader["PreviousSchoolId"].ToString()),
                ResponsiblePersonId = Convert.ToInt32(dataReader["ResponsiblePersonId"].ToString())

            };
            return tempStudent;
        }

        #endregion

        #region PublicMethod

        public static List<Student> GetStudents()
        {
            string sqlStatement = "SELECT * FROM  [dbo].[Students];";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Student> result = BaseDataManager.GetSPItems<Student>(sqlCommand, StudentMapper);
            return result;
        }

        public static int InsertStudent(Student student)
        {
            if (student == null) return 0;
            //SQL Statement
            string sqlStatement = "INSERT INTO  [dbo].[Students] " +
                                  "(ID,FirstName,IsMale,DateOfBirth," +
                                  "PlaceOfBirth,MobilePhoneNumber,WhatsappPhoneNumber,LandLine,AddressId," +
                                  "JoinDate,LeaveDate,FatherId,MotherId,ResponsiblePersonId,PreviousSchoolId)" +
                                  "VALUES " +
                                  "(@id,@firstName,@isMale,@dateOfBirth,@placeOfBirth,@mobileNum,@whatsNum,@landLine,@addressId," +
                                  "@joinDate,@leaveDate,@fatherId,@motherId,@responsiblePersonId,@previousSchoolId);";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", student.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@firstName", student.FirstName));
            sqlCommand.Parameters.Add(new SqlParameter("@ismale", student.IsMale ? "1" : "0"));
            sqlCommand.Parameters.Add(new SqlParameter("@dateofBirth", student.DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@placeOfBirth", student.PlaceOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@mobileNum", student.MobilePhoneNumber));
            sqlCommand.Parameters.Add(new SqlParameter("@whatsNum", student.WhatsAppPhoneNumber));
            sqlCommand.Parameters.Add(new SqlParameter("@landLine", student.LandLine));
            sqlCommand.Parameters.Add(new SqlParameter("@addressId", student.AddressId));
            sqlCommand.Parameters.Add(new SqlParameter("@joinDate", student.JoinDate));
            sqlCommand.Parameters.Add(new SqlParameter("@leaveDate", student.LeaveDate));
            sqlCommand.Parameters.Add(new SqlParameter("@fatherId", student.FatherId));
            sqlCommand.Parameters.Add(new SqlParameter("@motherId", student.MotherId));
            sqlCommand.Parameters.Add(new SqlParameter("@responsiblePersonId", student.ResponsiblePersonId));
            sqlCommand.Parameters.Add(new SqlParameter("@previousSchoolId", student.PreviousSchoolId));

            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }



        public static int UpdateStudent(Student student)
        {
            if (student == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[Students] SET " +
                                  "FirstName=@firstName,IsMale=@isMale,DateOfBirth=@dateOfBirth," +
                                   "PlaceOfBirth=@placeOfBirth,MobilePhoneNumber=@mobileNum,WhatsAppPhoneNumber=@whatsNum" +
                                   ",LandLine=@landLine,AddressId=@addressId,JoinDate=@joinDate," +
                                   "LeaveDate=@leaveDate," +
                                   "FatherId=@fatherId,MotherId=@motherId,ResponsiblePersonId=@responsiblePersonId," +
                                  "PreviousSchoolId=@previousSchoolId " +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", student.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@firstName", student.FirstName));
            sqlCommand.Parameters.Add(new SqlParameter("@ismale", student.IsMale ? "1" : "0"));
            sqlCommand.Parameters.Add(new SqlParameter("@dateofBirth", student.DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@placeOfBirth", student.PlaceOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@mobileNum", student.MobilePhoneNumber));
            sqlCommand.Parameters.Add(new SqlParameter("@whatsNum", student.WhatsAppPhoneNumber));
            sqlCommand.Parameters.Add(new SqlParameter("@landLine", student.LandLine));
            sqlCommand.Parameters.Add(new SqlParameter("@addressId", student.AddressId));
            sqlCommand.Parameters.Add(new SqlParameter("@joinDate", student.JoinDate));
            sqlCommand.Parameters.Add(new SqlParameter("@leaveDate", student.LeaveDate));
            sqlCommand.Parameters.Add(new SqlParameter("@fatherId", student.FatherId));
            sqlCommand.Parameters.Add(new SqlParameter("@motherId", student.MotherId));
            sqlCommand.Parameters.Add(new SqlParameter("@responsiblePersonId", student.ResponsiblePersonId));
            sqlCommand.Parameters.Add(new SqlParameter("@previousSchoolId", student.PreviousSchoolId));

            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }



        #endregion
    }
}
