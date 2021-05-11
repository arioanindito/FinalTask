using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Models
{
    public class Book : BaseEntity
    {
        public Book()
        {
            Images = new List<Image>();
        }
        [Key]
        public int BookId { get; set; }
        [DisplayName("Book Name")]
        [Required(ErrorMessage = "Book Name is Required!")]
        [StringLength(50)]
        public string BookName { get; set; }
        [Required(ErrorMessage = "ISBN is Required!")]
        [StringLength(50)]
        public string ISBN { get; set; }

        public ICollection<Image> Images { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
