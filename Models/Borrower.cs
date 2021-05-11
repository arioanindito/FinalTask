using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Models
{
    public enum Gender
    {
        Male, Female
    }
    public class Borrower : BaseEntity
    {
        [Key]
        public int BorrowerId { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required!")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required!")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is Required!")]
        public DateTime DOB { get; set; }
        [DisplayName("Status")]
        public int StatusId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Registration Date")]
        [Required(ErrorMessage = "Registration Date is Required!")]
        public DateTime RegistrationDate { get; set; }
        public Gender? Gender { get; set; }

        [DisplayName("Status")]
        public Status Statuses { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
