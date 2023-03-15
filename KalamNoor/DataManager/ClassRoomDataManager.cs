using KalamNoor.Models.Classes;
using System.Data;
using System.Data.SqlClient;

namespace KalamNoor.DataManager
{
    public abstract class ClassRoomDataManager
    {
        #region Mappers
        private static ClassRoom ClassRoomMapper(IDataReader dataReader)
        {
            ClassRoom tempClassRoom = new ClassRoom()
            {
                ID = Convert.ToInt32(dataReader["ID"].ToString()),
                Name = dataReader["Name"].ToString(),
                ClassId = Convert.ToInt32(dataReader["ClassId"].ToString()),
            };
            return tempClassRoom;
        }
        #endregion
        #region PublicMetheds

        public static List<ClassRoom> GetClasseRooms()
        {
            //SQL Statement
            string sqlStatement = "SELECT * FROM  [dbo].[ClassRooms]";
            //Preparing SQL Command
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            //Execute Query
            List<ClassRoom> result = BaseDataManager.GetSPItems<ClassRoom>(sqlCommand, ClassRoomMapper);
            return result;
        }
        public static int InsertClassRoom(ClassRoom classRoom)
        {
            if (classRoom == null) return 0;

            string sqlStatement = "INSERT INTO  [dbo].[ClassRooms] (Name,ClassId) " +
                                  "VALUES (@name,@classId)";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@name", classRoom.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@classId", classRoom.ClassId));


            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }
        public static int UpdateClassRoom(ClassRoom classRoom)
        {
            if (classRoom == null) return 0;

            string sqlStatement = "UPDATE  [dbo].[ClassRooms] SET " +
                                  "Name=@name,ClassId=@classId " +
                                  "WHERE ID=@id;";


            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };
            sqlCommand.Parameters.Add(new SqlParameter("@id", classRoom.ID));
            sqlCommand.Parameters.Add(new SqlParameter("@name", classRoom.Name));
            sqlCommand.Parameters.Add(new SqlParameter("@classId", classRoom.ClassId));


            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        public static int DeleteClassRoom(ClassRoom classRoom)
        {
            if (classRoom == null) return 0;

            string sqlStatement = "DELETE FROM [dbo].[ClassRooms] WHERE ID=@id;";

            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = sqlStatement,
                CommandType = CommandType.Text,
            };

            sqlCommand.Parameters.Add(new SqlParameter("@id", classRoom.ID));

            int result = BaseDataManager.ExecuteNonQuery(sqlCommand);
            return result;
        }

        #endregion
    }
}
