using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.Entites
{
    public interface IBaseEntity<TIdentity> where TIdentity: IComparable
    {
        TIdentity Id { get; set; }
    }
}
