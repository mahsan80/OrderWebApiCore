using System.ComponentModel.DataAnnotations;

namespace OrderWebApiCore.Entities
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        public int ProductID { get; set; }  

        public int CustomerID { get; set; }

        public decimal SalePrice { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
