using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Domain.Entities
{
    public class Post
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string Descriptions { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        [ForeignKey("UserId")]
        public User User { get; set; }

        public ICollection<Saved> Saveds { get; set; }

    }
}