using System.ComponentModel.DataAnnotations.Schema;

namespace GYMSystem_Part01.Entites
{
    [ComplexType]
    public class Address
    {
        public string City { get; set; } = default!;
        public string Street { get; set; } = default!;
        public int BuildingNumber { get; set; }

    }
}
