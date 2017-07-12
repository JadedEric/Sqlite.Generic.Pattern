using Sqlite.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Repository
{
    public interface IEntityBaseRepository<TEntity, TIdentity>: 
        IBaseRepository<TEntity, TIdentity> where TEntity: class, 
        IBaseEntity<TIdentity> where TIdentity: IComparable
    {
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] properties);

        void Add(TEntity entity);

        void Edit(TEntity entity);

        void Remove(TEntity entity);

        TIdentity Save();
    }
}
