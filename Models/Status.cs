using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Models
{
    public class Status : BaseEntity
    {
        [Key]
        public int StatusId { get; set; }
        [DisplayName("Status Name")]
        [Required(ErrorMessage = "Status Name is required!")]
        public string StatusName { get; set; }
    }
}
