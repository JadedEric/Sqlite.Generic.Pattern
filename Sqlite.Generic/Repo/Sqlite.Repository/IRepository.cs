using Sqlite.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Repository
{
    public interface IRepository<TEntity> : 
        IBaseRepository<TEntity, int> where TEntity: class, IBaseEntity<int>
    {
    }
}
