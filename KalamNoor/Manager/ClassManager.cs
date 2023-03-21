using KalamNoor.DataManager;
using KalamNoor.Models.Classes;

namespace KalamNoor.Manager
{
    public abstract class ClassManager
    {
        public static int InsertClass(Class cls)
        {
            return ClassDataManager.InsertClass(cls);
        }
        public static int UpdateClass(Class cls)
        {
            return ClassDataManager.UpdateClass(cls);
        }
        public static int DeleteClass(Class cls)
        {
            return ClassDataManager.DeleteClass(cls);
        }
        public static List<Class> GetClasses()
        {
            return ClassDataManager.GetClasses().ToList();
        }
        public static Class GetClassById(int id)
        {
            List<Class> classes = GetClasses();
            foreach (Class cls in classes)
            {
                if (cls.ID==id)
                {
                    return cls;
                }
            }
            return null;
        }
        
    }
}
