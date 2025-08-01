using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Domain.Entities
{
    public class Reports
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ReporterId { get; set; }

        public Guid? ReportedUserId { get; set; }

        public Guid? ReportedPostId { get; set; }

        [Required]
        public Guid ReportTypeId { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(50)]
        public string? Status { get; set; }

        // Navigation properties
        [ForeignKey("ReporterId")]
        public User Reporter { get; set; } // The user who trigger the report

        [ForeignKey("ReportedUserId")]
        public User ReportedUser { get; set; } // User who receive the report

        [ForeignKey("ReportedPostId")]
        public Post ReportedPost { get; set; } // The Blog that report to

        [ForeignKey("ReportTypeId")]
        public ReportType ReportType { get; set; }
    }
}