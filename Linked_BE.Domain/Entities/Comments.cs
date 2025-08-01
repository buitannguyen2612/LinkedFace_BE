using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Domain.Entities
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;

        // Navigation properties
        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}