using KalamNoor.DataManager;
using KalamNoor.Models.YearsRecords;

namespace KalamNoor.Manager
{
    public abstract class YearReccordManger
    {
        public static List<YearRecord> GetYearRecords()
        {
            return YearReccordDataManager.GetYearRecords().ToList();
        }
        public static int InsertYearReccord(YearRecord record)
        {
            return YearReccordDataManager.InsertYearReccord(record);
        }
        public static int UpdateYearREccord(YearRecord record)
        {
            return YearReccordDataManager.UpdateYearReccord(record);
        }
    }
}
