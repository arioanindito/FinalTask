using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Models
{
    public enum BookCondition
    {
        LikeNew, Good, Average, Fair, Poor
    }
    public class Loan : BaseEntity
    {
        [Key]
        public int LoanId { get; set; }
        [Required(ErrorMessage = "Member is required.")]
        [DisplayName("Member Name")]
        public int BorrowerId { get; set; }
        [Required(ErrorMessage = "Book is required.")]
        [DisplayName("Book Name")]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Start Date is required.")]
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End Date is required.")]
        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }
        [DisplayName("Book Condition")]
        public BookCondition? BookCondition { get; set; }

        public Borrower Borrowers { get; set; }
        [DisplayName("Book")]
        public Book Books { get; set; }
    }
}