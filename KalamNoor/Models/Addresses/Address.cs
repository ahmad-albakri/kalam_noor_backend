using System.Reflection.PortableExecutable;

namespace KalamNoor.Models.Addresses
{
    public class Address
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AdditionalDetails { get; set; }
        public int AreaId { get; set; }
    }
}
