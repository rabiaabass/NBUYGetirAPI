using NBUYGetirCore.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Repositories
{

    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(string Id);
        TEntity Find(string Id);

        /// <summary>
        /// Filtreleme yapmak için kullanıcağız.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        List<TEntity> List();

        /// <summary>
        /// Böyle bir kayıt var mı?
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        bool Any(Expression<Func<TEntity, bool>> expression);

    }
}
