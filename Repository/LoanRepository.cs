using DSS_MVC.Models;
using DSS_MVC.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Repository
{
    public class LoanRepository:ILoan
    {
        private DBContext db;
        public LoanRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Loan> GetLoans => db.Loans.Include(s => s.Borrowers).Include(c => c.Books);
        public void Add(Loan _Loan)
        {
            if (_Loan.LoanId == 0)
            {
                db.Loans.Add(_Loan);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Loans.Find(_Loan.LoanId);
                dbEntity.BorrowerId = _Loan.BorrowerId;
                dbEntity.BookId = _Loan.BookId;
                dbEntity.StartDate = _Loan.StartDate;
                dbEntity.EndDate = _Loan.EndDate;
                db.SaveChanges();
            }
        }
        public Loan GetLoan(int? ID)
        {
            return db.Loans.Include(e => e.Borrowers)
                .Include(b => b.Books)
                .SingleOrDefault(a => a.LoanId == ID);
        }
        public void Remove(int? ID)
        {
            Loan dbEntity = db.Loans.Find(ID);
            db.Loans.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
