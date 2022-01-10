using NBUYGetirCore.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Repositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : IAggregateRoot
    {
        TEntity Find(string Id);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> List();
    }
}
