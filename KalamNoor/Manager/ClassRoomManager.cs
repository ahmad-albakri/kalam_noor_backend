using KalamNoor.DataManager;
using KalamNoor.Models.Classes;

namespace KalamNoor.Manager
{
    public abstract class ClassRoomManager
    {
        public static int InsertClassRoom(ClassRoom classRoom)
        {
            return ClassRoomDataManager.InsertClassRoom(classRoom);
        }

        public static int UpdateClassRoom(ClassRoom classRoom)
        {
            return ClassRoomDataManager.UpdateClassRoom(classRoom);
        }
        public static int DeleteClassRoom(ClassRoom classRoom)
        {
            return ClassRoomDataManager.DeleteClassRoom(classRoom);
        }

        public static List<ClassRoom> GetClassRooms()
        {
            return ClassRoomDataManager.GetClasseRooms().ToList();
        }
        public static ClassRoom GetClassRoomById(int id)
        {
            List<ClassRoom> classRooms = GetClassRooms();
            foreach (ClassRoom classRoom in classRooms)
            {
                if (classRoom.ID == id)
                {
                    return classRoom;
                }
                return null;
            }
        }
    }
}
