using LeaveApprouvment.Domains.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Infrastrectures.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly DBContext _dbset;
        public RepositoryBase(DBContext dbset)
        {
            _dbset = dbset;
        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
            _dbset.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            _dbset.Update(entity);
            _dbset.SaveChanges();
        }
        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
            _dbset.SaveChanges();

        }
    }
}
