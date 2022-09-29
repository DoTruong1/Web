using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("Banner")]
    public class Banner: BaseEntity
    {
        public string Image { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }
    }
}