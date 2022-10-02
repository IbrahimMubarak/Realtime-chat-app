using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            Messages = new HashSet<Message>();
        }
        public byte[] ProfilePicture { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
