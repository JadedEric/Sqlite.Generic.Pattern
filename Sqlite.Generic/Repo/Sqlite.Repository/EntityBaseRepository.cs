using Sqlite.Context;
using Sqlite.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Sqlite.Repository
{
    public class EntityBaseRepository<TEntity, TIdentity>: 
        IEntityBaseRepository<TEntity, TIdentity> where TEntity: class,
        IBaseEntity<TIdentity> where TIdentity: IComparable
    {
        private readonly IEntityContext _context;

        public EntityBaseRepository(IEntityContext context)
        {
            if (null == context)
            {
                throw new ArgumentNullException("context");
            }

            _context = context;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            var query = GetAll().Where(predicate);
            return query;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] properties)
        {
            var query = GetAll();

            foreach (var property in properties)
            {
                query = query.Include(property);
            }

            return query;
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TIdentity Save()
        {
            throw new NotImplementedException();
        }
    }
}
