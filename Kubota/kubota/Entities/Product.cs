using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("Product")]
    public class Product: BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }

        public string Code { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }
    }
}