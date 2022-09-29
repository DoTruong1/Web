using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("User")]
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Gmail { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public int Gender { get; set; }
    }
}