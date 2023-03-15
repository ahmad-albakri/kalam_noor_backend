using KalamNoor.DataManager;
using KalamNoor.Models.Classes;

namespace KalamNoor.Manager
{
    public abstract class ClassRoomManager
    {
        public static int InsertClassRoom (ClassRoom classRoom)
        {
            return ClassRoomDataManager.InsertClassRoom(classRoom);
        }

        public static int UpdateClassRoom(ClassRoom classRoom)
        {
            return ClassRoomDataManager.UpdateClassRoom(classRoom);
        }
        public static int DeleteClassRoom (ClassRoom classRoom) 
        {
        return ClassRoomDataManager.DeleteClassRoom(classRoom);
        }

        public static List<ClassRoom> GetClassRooms() 
        {
            return ClassRoomDataManager.GetClasseRooms().ToList();
        }
    }
}
