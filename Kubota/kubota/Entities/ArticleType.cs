using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("ArticleType")]
    public class ArticleType: BaseEntity
    {
        public string Name { get; set; }

        public string Slug { get; set; }
    }
}