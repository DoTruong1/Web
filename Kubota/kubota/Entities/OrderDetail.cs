using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid OrderId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}