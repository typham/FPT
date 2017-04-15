using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Model.Models
{
    [Table("Permissions")]
    public class Permission
    {
        public int Id { get; set; }
        public int RoleID { get; set; }
        public string ListPermission { get; set; }
    }
}
