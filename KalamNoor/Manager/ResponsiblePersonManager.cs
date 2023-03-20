using KalamNoor.DataManager;
using KalamNoor.Models.Families;

namespace KalamNoor.Manager
{
    public abstract class ResponsiblePersonManager
    {
        public static List<ResponsiblePerson> GetResponsiblePeoples()
        {
            return ResponsiblePersonDataManager.GetResponsiblePersons().ToList();
        }
        public static int InsertResponsiblePerson(ResponsiblePerson responsiblePerson)
        {
            return ResponsiblePersonDataManager.InsertResponsiblePerson(responsiblePerson);
        }
        public static int UpdateResponsiblePerson(ResponsiblePerson responsiblePerson)
        {
            return ResponsiblePersonDataManager.UpdateResponsiblePerson(responsiblePerson);
        }
        public static int DeleteResponsiblePerson(ResponsiblePerson responsiblePerson)
        {
            return ResponsiblePersonDataManager.DeleteResponsiblePerson(responsiblePerson);
        }

    }
}
