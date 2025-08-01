using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linked_BE.Domain.Entities
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ReceiverUserId { get; set; }

        [Required]
        public Guid SenderUserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string NotyTypeEnum { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Content { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

        // Navigation properties
        [ForeignKey("SenderUserId")]
        public User SenderUser { get; set; }

        [ForeignKey("ReceiverUserId")]
        public User ReceiverUser { get; set; }
    }
}
