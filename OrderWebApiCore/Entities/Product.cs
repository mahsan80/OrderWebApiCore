using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dapper.Core.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public decimal RecommendedPrice { get; set; }
        public string Category { get; set; } = String.Empty;

    }
}
