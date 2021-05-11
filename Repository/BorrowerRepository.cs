using DSS_MVC.Models;
using DSS_MVC.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Repository
{
    public class BorrowerRepository : IBorrower
    {
        private DBContext db;
        public BorrowerRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Borrower> GetBorrowers => db.Borrowers.Include(g => g.Statuses);
        public void Add(Borrower _Borrower)
        {
            if (_Borrower.BorrowerId == 0)
            {
                db.Borrowers.Add(_Borrower);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Borrowers.Find(_Borrower.BorrowerId);
                dbEntity.FirstName = _Borrower.FirstName;
                dbEntity.LastName = _Borrower.LastName;
                dbEntity.DOB = _Borrower.DOB;
                dbEntity.StatusId = _Borrower.StatusId;
                dbEntity.RegistrationDate = _Borrower.RegistrationDate;
                dbEntity.Gender = _Borrower.Gender;
                db.SaveChanges();
            }
        }
        public Borrower GetBorrower(int? ID)
        {
            Borrower dbEntity = db.Borrowers.Include(e => e.Loans)
                                            .ThenInclude(c => c.Books)
                                            .Include(g => g.Statuses)
                                            .SingleOrDefault(m => m.BorrowerId == ID);
            return dbEntity;
        }
        public void Remove(int? ID)
        {
            Borrower dbEntity = db.Borrowers.Find(ID);
            db.Borrowers.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
