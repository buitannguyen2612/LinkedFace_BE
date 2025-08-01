using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Domain.Entities
{
    public class Friendships
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int RequesterId { get; set; }

        [Required]
        public int ReceiverId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey("RequesterId")]
        public User Requester { get; set; }

        [ForeignKey("ReceiverId")]
        public User Receiver { get; set; }
    }
}