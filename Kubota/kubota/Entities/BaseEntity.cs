using System;
using System.ComponentModel.DataAnnotations;

namespace Kubota.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }
        
        public DateTime? UpdateDate { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid UpdateBy { get; set; }

        public int Status { get; set; }
    }
}