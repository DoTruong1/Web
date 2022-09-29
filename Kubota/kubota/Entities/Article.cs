using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("Article")]
    public class Article: BaseEntity
    {
        public string Title { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public Guid ArticleTypeId { get; set; }
    }
}