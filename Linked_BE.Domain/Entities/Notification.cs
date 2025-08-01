using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linked_BE.Domain.Entities
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ReceiverUserId { get; set; }

        [Required]
        public int SenderUserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string NotyTypeID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Content { get; set; }

        public DateTime CreateAt { get; set; }

        // Navigation properties
        [ForeignKey("SenderUserId")]
        public User SenderUser { get; set; }

        [ForeignKey("ReceiverUserId")]
        public User ReceiverUser { get; set; }
    }
}
