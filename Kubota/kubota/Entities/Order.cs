using System;
using System.ComponentModel.DataAnnotations.Schema;
using Kubota.Common;

namespace Kubota.Entities
{
    [Table("Order")]
    public class Order
    {
        public Guid Id { get; set; }

        public decimal TotalPrice { get; set; }

        public string UserName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Note { get; set; }

        public PaymentType PaymentType { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}