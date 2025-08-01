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
        public Guid Id { get; set; }

        [Required]
        public Guid RequesterId { get; set; }

        [Required]
        public Guid ReceiverId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey("RequesterId")]
        public User Requester { get; set; }

        [ForeignKey("ReceiverId")]
        public User Receiver { get; set; }
    }
}