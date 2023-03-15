using KalamNoor.Models.Addresses;
using KalamNoor.Models.Families;
using KalamNoor.Models.Students;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class FatherDataManager
    {
        #region FatherMapper
        private static Father FatherMapper(IDataReader dataReader)
        {
            Father tempFather = new Father()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                FirstName = dataReader["FirstName"].ToString(),
                FatherName = dataReader["FatherName"].ToString(),
                MotherName = dataReader["MotherName"].ToString(),
                LastName = dataReader["LastName"].ToString(),
                Carrer = dataReader["Carrer"].ToString(),
                DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"].ToString()),
                PlaceOfBirth = dataReader["PlaceOfBirth"].ToString(),
                Religion = (Father.ReligionEnum)Convert.ToInt32(dataReader["Religion"].ToString()),
                TiePlace = dataReader["TiePlace"].ToString(),
                NationalIdNumber = dataReader["NationalIdNumber"].ToString(),
                TieNumber = dataReader["TieNumber"].ToString(),
            };
            return tempFather;
        }

        #endregion

        #region PublicMethods
        public static List<Father> GetFathers()
        {
            string sqlStatement = "SELECT * FROM  [dbo].[Fathers];";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Father> result = BaseDataManager.GetSPItems<Father>(sqlCommand, FatherMapper);
            return result;
        }

        public static int InsertFather(Father father)
        {
            if (father == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Fathers] (FirstName,FatherName,MotherName," +
                                  "LastName,Carrer,DateOfBirth,PlaceOfBirth,Religion,NationalIdNumber,TiePlace,TieNumber) " +
                                  "VALUES (@firstName,@fatherName,@motherName," +
                                  "@lastName,@carrer,@dateOfBirth,@placOfBirth,@religion,@nationalId,@tiePlace,@tieNumber)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@firstName", father.FirstName));
            sqlCommand.Parameters.Add(new SqlParameter("@fatherName", father.FatherName));
            sqlCommand.Parameters.Add(new SqlParameter("@motherName", father.MotherName));
            sqlCommand.Parameters.Add(new SqlParameter("@lastName", father.LastName));
            sqlCommand.Parameters.Add(new SqlParameter("@carrer", father.Carrer));
            sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", father.DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@placOfBirth", father.PlaceOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@religion", (int)father.Religion));
            sqlCommand.Parameters.Add(new SqlParameter("@nationalId", father.NationalIdNumber));
            sqlCommand.Parameters.Add(new SqlParameter("@tiePlace", father.TiePlace));
            sqlCommand.Parameters.Add(new SqlParameter("tieNumber", father.TieNumber));





            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateFather(Father father)
        {

            if (father == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[Fathers] SET " +
                                  "FirstName=@firstName,FatherName=@fatherName,MotherName=@motherName,LastName=@lastName," +
                                  "Carrer=@carrer,DateOfBirth=@dateOfBirth,PlaceOfBirth=@placeOfBirth,Religion=@religion," +
                                  "NationalIdNumber=@nationalId,TiePlace=@tiePlace,TieNumber=@tieNumber" +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("ID",father.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@firstName", father.FirstName));
            sqlCommand.Parameters.Add(new SqlParameter("@fatherName", father.FatherName));
            sqlCommand.Parameters.Add(new SqlParameter("@motherName", father.MotherName));
            sqlCommand.Parameters.Add(new SqlParameter("@lastName", father.LastName));
            sqlCommand.Parameters.Add(new SqlParameter("@carrer", father.Carrer));
            sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", father.DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@placOfBirth", father.PlaceOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@religion", (int)father.Religion));
            sqlCommand.Parameters.Add(new SqlParameter("@nationalId", father.NationalIdNumber));
            sqlCommand.Parameters.Add(new SqlParameter("@tiePlace", father.TiePlace));
            sqlCommand.Parameters.Add(new SqlParameter("@tieNumber", father.TieNumber));

            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeleteFather(Father father)
        {
            if (father == null) return 0;
            //SQL Statement
            string sqlStatement = "DELETE FROM [dbo].[Fathers] WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };


            sqlCommand.Parameters.Add(new SqlParameter("@id", father.ID));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        #endregion

    }
}
