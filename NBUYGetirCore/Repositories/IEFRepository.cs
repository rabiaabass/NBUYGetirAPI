using NBUYGetirCore.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Repositories
{
    public interface IEFRepository<TEntity>:IReadOnlyRepository<TEntity>,IWriteOnlyRepository<TEntity> where TEntity:IAggregateRoot
    {

    }
}
