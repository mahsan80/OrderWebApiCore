using System.ComponentModel.DataAnnotations;

namespace OrderWebApiCore.Entities
{
    public class Customer
    {

        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = string.Empty;
        public string City { get; set; } = String.Empty;

        public string State { get; set; } = string.Empty;

        public string Zip { get; set; } = string.Empty;

    }
}
