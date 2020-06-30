using AuthApi.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Models
{
    [Table("AspNetUsers")]
    public class User: IdentityUser<Guid>
    {
        [Key]
        public override Guid Id { get; set; }

        public override string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Email này không hợp lệ")]
        public string EmailAddress { get; set; }

        public int? Status { get; set; }

        public string Avatar { get; set; }

        public string ThumbnailPhoto { get; set; }

        public bool? IsLdapUser { get; set; }

        public int? Gender { get; set; }

        public string BirthDay { get; set; }

        public string Position { get; set; }

        [InverseProperty("User")]
        public ICollection<UserRole> RoleUser { get; set; }
    }
}
