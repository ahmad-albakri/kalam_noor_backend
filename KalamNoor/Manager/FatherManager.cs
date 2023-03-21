﻿using KalamNoor.DataManager;
using KalamNoor.Models.Families;
using KalamNoor.Models.Students;

namespace KalamNoor.Manager
{
    public abstract class FatherManager
    {
        public static List<Father> GetFathers()
        {
            return FatherDataManager.GetFathers().ToList();
        }
        public static int InsertFather(Father father)
        {
            return FatherDataManager.InsertFather(father);

        }
        public static int UpdateFather(Father father)
        {
            return FatherDataManager.UpdateFather(father);
        }
        public static int DeleteFather(Father father)
        {

            return FatherDataManager.DeleteFather(father);

        }
        public static Father GetFatherById(int id)
        {
            List<Father> fathers = GetFathers();
            foreach (Father father in fathers)
            {
                if (father.ID == id)
                {
                    return father;
                }
            }
            return null;
        }
    }
}
