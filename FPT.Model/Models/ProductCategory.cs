using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Model.Models
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
