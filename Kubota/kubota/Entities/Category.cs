using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kubota.Entities
{
    [Table("Category")]
    public class Category: BaseEntity
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public string Slug { get; set; }

        public Guid ParentId { get; set; }
    }
}