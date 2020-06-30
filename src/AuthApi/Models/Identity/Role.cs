using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Models.Identity
{
    [Table("AspNetRoles")]
    public class Role: IdentityRole<Guid>
    {
    }
}
