using Sqlite.Context;
using Sqlite.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Repository
{
    public class EntityRepository<TEntity>:
        EntityBaseRepository<TEntity, int>, IEntityRepository<TEntity> where TEntity: class, IBaseEntity<int>
    {
        public EntityRepository(IEntityContext context)
            : base(context)
        {

        }
    }
}
