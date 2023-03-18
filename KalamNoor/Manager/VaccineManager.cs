using KalamNoor.DataManager;
using KalamNoor.Models.Vaccines;

namespace KalamNoor.Manager
{
    public abstract class VaccineManager
    {
        public static List<Vaccine> GetVaccines()
        {

            return VaccineDataManager.GetVaccines().ToList();
        }

        public static int InsertVaccine(Vaccine vaccine)
        {
            return VaccineDataManager.InsertVaccine(vaccine);
        }
        public static int UpdateVaccine(Vaccine vaccine)
        {
            return VaccineDataManager.UpdateVaccine(vaccine);
        }
        public static int DeleteVaccine(Vaccine vaccine)
        {

            return VaccineDataManager.DeleteVaccine(vaccine);
        }
    }
}
