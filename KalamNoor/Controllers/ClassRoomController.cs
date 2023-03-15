using KalamNoor.Manager;
using KalamNoor.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class ClassRoomController : ControllerBase
    {
        [Route("ClassRoomController/InsertClassRoom")]
        [HttpPost]
        public int InsertClassRoom(ClassRoom classRoom)
        {
            return ClassRoomManager.InsertClassRoom(classRoom);
        }
        [Route("ClassRoomController/UpdateClassRoom")]
        [HttpPost]
        public int UpdateClassRoom(ClassRoom classRoom)
        {
            return ClassRoomManager.UpdateClassRoom(classRoom);
        }
        [Route("ClassRoomController/DeleteClassRoom")]
        [HttpPost]
        public int DeleteClassRoom(ClassRoom classRoom)
        {
            return ClassRoomManager.DeleteClassRoom(classRoom);
        }


        [Route("ClassRoomController/GetClasseRooms")]
        [HttpGet]
        public List<ClassRoom> GetClasseRooms()
        {
            return ClassRoomManager.GetClassRooms();
        }

    }
}

