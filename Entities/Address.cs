using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Entities
{
    public class Address
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
