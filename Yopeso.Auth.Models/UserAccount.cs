using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Yopeso.Auth.Models
{
    public class UserAccount : BaseModel
    {
        public long Id { get; set; }

        [StringLength(40)]
        public string Username { get; set; }

        [EmailAddress]
        [StringLength(80)]
        public string Email { get; set; }

        [StringLength(80)]
        public string Password { get; set; }

        [StringLength(100)]
        public string PasswordSalt { get; set; }

        public ICollection<Role> Roles { get; } = new List<Role>();
    }
}