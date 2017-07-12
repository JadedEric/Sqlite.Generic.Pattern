using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Context
{
    public abstract class EntityContext : DbContext, IEntityContext
    {
        protected EntityContext(): base()
        {

        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity: class
        {
            return base.Set<TEntity>();
        }
    }
}
