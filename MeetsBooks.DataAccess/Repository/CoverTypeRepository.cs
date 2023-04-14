using MeetsBooks.DataAccess.Repository.IRepository;
using MeetsBooks.Models;
using MeetsBookstore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
