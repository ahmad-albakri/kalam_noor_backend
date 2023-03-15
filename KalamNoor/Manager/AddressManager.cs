using KalamNoor.DataManager;
using KalamNoor.Models.Addresses;

namespace KalamNoor.Manager
{
    public abstract class AddressManager
    {
        public static int InsertAddress(Address address)
        {
            return AddressDataManager.InsertAddress(address);
        }
        public static int UpdateAddress(Address address)
        {
            return AddressDataManager.UpdateAddress(address);
        }
        public static int DeleteAddress(Address address)
        {
            return AddressDataManager.DeleteAddress(address);
        }
        public static List<Address> GetAddresses() 
        { 
        return AddressDataManager.GetAddresses().ToList();
        
        }

    }
}
