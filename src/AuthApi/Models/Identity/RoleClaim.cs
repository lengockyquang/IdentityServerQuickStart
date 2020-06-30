using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Models.Identity
{
    [Table("AspNetRoleClaims")]
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
    }
}
