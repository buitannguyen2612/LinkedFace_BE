using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Domain.Entities
{
    public class Images
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public Guid? PostId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ImageKey { get; set; }

        // Navigation properties

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}