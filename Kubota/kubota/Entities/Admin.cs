using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("Admin")]
    public class Admin: BaseEntity
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string Avatar { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}