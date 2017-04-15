using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Model.Models
{
    [Table("Roles")]
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

    }
}
