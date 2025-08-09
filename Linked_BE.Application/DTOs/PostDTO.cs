using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_BE.Application.DTOs
{
    public class PostDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public UserDTO User { get; set; }
    }

    public class PostCreateDTO
    {

        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Descriptions { get; set; }

        public List<ImagesDTO> Image { get; set; }

    }


    public class UserDTO
    {
        public Guid Id { get; set; }

        public string Auth0UserId { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AvatarKey { get; set; }

    }

    public class ImagesDTO
    {
        public Guid UserId { get; set; }

        public Guid? PostId { get; set; }

        public string ImageKey { get; set; }
    }

}