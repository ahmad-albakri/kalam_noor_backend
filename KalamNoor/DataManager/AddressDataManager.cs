using KalamNoor.Models.Addresses;
using KalamNoor.Models.Cities;
using KalamNoor.Models.Students;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class AddressDataManager
    {
        #region AddressMapper
        private static Address AddressMapper(IDataReader dataReader)
        {
            Address tempAddress = new Address()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
                AreaId = Convert.ToInt32(dataReader["AreaId"].ToString()),
                AdditionalDetails = dataReader["AdditionalDetails"].ToString(),
            };
            return tempAddress;
        }
        #endregion

        #region PublicMethods
        public static List<Address> GetAddresses()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[Addresses]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<Address> result = BaseDataManager.GetSPItems<Address>(sqlCommand, AddressMapper);
            return result;
        }

        public static int InsertAddress(Address address)
        {
            if (address == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[Addresses] (Name,AreaId,AdditionalDetails) " +
                                  "VALUES (@name,@areaId,@additionalDetails)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", address.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@areaId", address.AreaId));
            sqlCommand.Parameters.Add(new SqlParameter("@additionalDetails", address.AdditionalDetails));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        public static int UpdateAddress(Address address)
        {

            if (address == null) return 0;
            //SQL Statement
            string sqlStatement = "UPDATE  [dbo].[Addresses] SET " +
                                  "Name=@name,AreaId=@areaId,DateOfBirth=@dateOfBirth" +
                                  "WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", address.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", address.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@areaId", address.AreaId));
            sqlCommand.Parameters.Add(new SqlParameter("@additionalDetails", address.AdditionalDetails));

            //Execute Query
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int DeleteAddress(Address address)
        {
            if (address == null) return 0;
            //SQL Statement
            string sqlStatement = "DELETE FROM [dbo].[Addresses] WHERE ID=@id;";

            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };


            sqlCommand.Parameters.Add(new SqlParameter("@id", address.ID));
            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        #endregion
    }
}
