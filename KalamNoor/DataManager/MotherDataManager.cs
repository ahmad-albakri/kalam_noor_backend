using KalamNoor.Models.Families;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class MotherDataManager
    {
        #region MotherMapper
        private static Mother MotherMapper(IDataReader dataReader)
        {
            Mother tempMother = new Mother()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                FirstName = dataReader["FirstName"].ToString(),
                FatherName = dataReader["FatherName"].ToString(),
                LastName = dataReader["LastName"].ToString(),
                MotherName = dataReader["MotherName"].ToString(),
                DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"].ToString()),
                PlaceOfBirth = dataReader["PlaceOfBirth"].ToString(),
                Religion = (Mother.MotherReligionEnum)Convert.ToInt32(dataReader["Religion"].ToString()),
                IsLiveWithHasband = (Convert.ToBoolean(dataReader["IsLiveWithHasband"].ToString())),
                Carrer = dataReader["Carrer"].ToString(),
                TiePlace = dataReader["TiePlace"].ToString(),
                EducationalStatus = dataReader["EducationalStatus"].ToString(),
                TieNumber = dataReader["TieNumber"].ToString(),
            };
            return tempMother;
        }

        #endregion

     
        #region publicMethods
        public static List<Mother> GetMothers()
        {
            string sqlStatement = "SELECT * FROM  [dbo].[Mothers];";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Mother> result = BaseDataManager.GetSPItems<Mother>(sqlCommand, MotherMapper);
            return result;
        }
        public static int InsertMother(Mother mother)
        {
            if (mother == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Mothers] (FirstName,FatherName,LastName,MotherName," +
                                  "DateOfBirth,PlaceOfBirth,Religion,IsLiveWithHasband,Carrer,TiePlace,EducationalStatus,TieNumber) " +
                                  "VALUES (@firstName,@fatherName,@lastName," +
                                  "@motherName,@dateOfBirth,@placOfBirth,@religion,@isLiveWithHasband,@carrer," +
                                  "@tiePlace,@educationalStatus,@tieNumber)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@firstName", mother.FirstName));
            sqlCommand.Parameters.Add(new SqlParameter("@fatherName", mother.FatherName));
            sqlCommand.Parameters.Add(new SqlParameter("@lastName", mother.LastName));
            sqlCommand.Parameters.Add(new SqlParameter("@motherName", mother.MotherName));
            sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", mother.DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@placOfBirth", mother.PlaceOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@religion", (int)mother.Religion));
            sqlCommand.Parameters.Add(new SqlParameter("@isLiveWithHasband", mother.IsLiveWithHasband ? "1" : "0"));
            sqlCommand.Parameters.Add(new SqlParameter("@carrer", mother.Carrer));
            sqlCommand.Parameters.Add(new SqlParameter("@tiePlace", mother.TiePlace));
            sqlCommand.Parameters.Add(new SqlParameter("@educationalStatus", mother.EducationalStatus));
            sqlCommand.Parameters.Add(new SqlParameter("tieNumber", mother.TieNumber));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateMother(Mother mother)
        {

            if (mother == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[Mothers] SET " +
                                  "FirstName=@firstName,FatherName=@fatherName,LastName=@lastName,MotherName=@motherName," +
                                  "DateOfBirth=@dateOfBirth,PlaceOfBirth=@placeOfBirth,Religion=@religion," +
                                  "IsLiveWithHasband=@isLiveWithHasband,Carrer=@carrer,TiePlace=@tiePlace," +
                                  "EducationalStatus=@educationalStatus,TieNumber=@tieNumber " +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };

            sqlCommand.Parameters.Add(new SqlParameter("@id", mother.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@firstName", mother.FirstName));
            sqlCommand.Parameters.Add(new SqlParameter("@fatherName", mother.FatherName));
            sqlCommand.Parameters.Add(new SqlParameter("@lastName", mother.LastName));
            sqlCommand.Parameters.Add(new SqlParameter("@motherName", mother.MotherName));
            sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", mother.DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@placOfBirth", mother.PlaceOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@religion", (int)mother.Religion));
            sqlCommand.Parameters.Add(new SqlParameter("@isLiveWithHasband", mother.IsLiveWithHasband ? "1" : "0"));
            sqlCommand.Parameters.Add(new SqlParameter("@carrer", mother.Carrer));
            sqlCommand.Parameters.Add(new SqlParameter("@tiePlace", mother.TiePlace));
            sqlCommand.Parameters.Add(new SqlParameter("@educationalStatus", mother.EducationalStatus));
            sqlCommand.Parameters.Add(new SqlParameter("tieNumber", mother.TieNumber));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeleteMother(Mother mother)
        {
            if (mother == null) return 0;
            //SQL Statement
            string sqlStatement = "DELETE FROM [dbo].[Mothers] WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };


            sqlCommand.Parameters.Add(new SqlParameter("@id", mother.ID));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }



        #endregion
    }

}
