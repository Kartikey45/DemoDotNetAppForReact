using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Interfaces;
using WebAPIDemo.Models;

namespace WebAPIDemo.Services
{
    public class User : IUser
    {
        private readonly ApplicationDbContext _db;
        public User(ApplicationDbContext db)
        {
            _db = db;
        }
        public EmpDetails Add(EmpDetails emp)
        {
            var Result = _db.Add(emp);
            _db.SaveChanges();

            if (Result != null)
            {
                return emp;
            }
            else
            {
                return null;
            }
        }

        public List<EmpDetails> View()
        {
            var data = _db.CrudEmpDetails.ToList();
            if (!data.Equals(null))
            {
                return data;
            }
            else
            {
                return null;
            }
        }
    }
}
