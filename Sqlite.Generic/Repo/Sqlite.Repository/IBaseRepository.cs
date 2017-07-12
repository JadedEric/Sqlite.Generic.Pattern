using Sqlite.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Repository
{
    public interface IBaseRepository<TEntity, TIdentity> where TEntity: class, 
        IBaseEntity<TIdentity> where TIdentity: IComparable
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

    }
}
