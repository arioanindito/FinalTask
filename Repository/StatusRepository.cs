using DSS_MVC.Models;
using DSS_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Repository
{
    public class StatusRepository : IStatus
    {
        private DBContext db;
        public StatusRepository(DBContext _db)
        {
            db = _db;
        }
        public IEnumerable<Status> GetStatuses => db.Statuses;

        public void Add(Status _Status)
        {
            if (_Status.StatusId == 0)
            {
                db.Statuses.Add(_Status);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Statuses.Find(_Status.StatusId);
                dbEntity.StatusName = _Status.StatusName;
                db.SaveChanges();
            }
        }
        public Status GetStatus(int? ID)
        {
            return db.Statuses.Find(ID);
        }
        public void Remove(int? ID)
        {
            Status dbEntity = db.Statuses.Find(ID);
            db.Statuses.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
