using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linked_BE.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Auth0UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Phone]
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? AvatarKey { get; set; }

        [MaxLength(100)]
        public string? CurrentLocation { get; set; }

        [MaxLength(100)]
        public string? Location { get; set; }

        // Navigation Properties
        public ICollection<Post> Posts { get; set; }
        public ICollection<Saved> Saveds { get; set; }
        public ICollection<Images> Images { get; set; }

        [InverseProperty("SenderUser")]
        public ICollection<Notification> NotificationsSent { get; set; }

        [InverseProperty("ReceiverUser")]
        public ICollection<Notification> NotificationsReceived { get; set; }

        [InverseProperty("Requester")]
        public ICollection<Friendships> FriendRequestsSent { get; set; }

        [InverseProperty("Receiver")]
        public ICollection<Friendships> FriendRequestsReceived { get; set; }

        [InverseProperty("Reporter")]
        public ICollection<Reports> ReportsSent { get; set; }

        [InverseProperty("ReportedUser")]
        public ICollection<Reports> ReportsReceived { get; set; }
    }
}
