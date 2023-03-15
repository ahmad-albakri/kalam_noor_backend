using KalamNoor.Manager;
using KalamNoor.Models.Addresses;
using KalamNoor.Models.Cities;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class AddressController : ControllerBase
    {
        [Route("AddressController/InsertAddress")]
        [HttpPost]
        public int InsertAddress([FromBody] Address address)
        {
            return AddressManager.InsertAddress(address);
        }
        [Route("AddressController/UpdateAddress")]
        [HttpPost]
        public int UpdateAddress([FromBody] Address address)
        {
            return AddressManager.UpdateAddress(address);
        }
        [Route("AddressController/DeleteAddress")]
        [HttpPost]
        public int DeleteAddress([FromBody] Address address)
        {
            return AddressManager.DeleteAddress(address);
        }
        [Route("AddressController/GetAddresses")]
        [HttpGet]
        public List<Address> GetAddresses()
        {
            return AddressManager.GetAddresses();

        }


    }
}
