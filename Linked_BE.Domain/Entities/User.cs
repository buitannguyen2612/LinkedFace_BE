using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentLocation { get; set; }
        public string Location { get; set; }

        // Navigation Properties
        public ICollection<Post> Posts { get; set; }
        public ICollection<Notification> NotificationsSent { get; set; }
        public ICollection<Notification> NotificationsReceived { get; set; }
    }
}