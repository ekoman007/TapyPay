﻿using Microsoft.EntityFrameworkCore.Query;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.Infrastructure.Contracts
{
    public interface IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
    {
        Task<IEnumerable<TEntity>> Get(
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>[] includes = null,
            CancellationToken cancellationToken = default);
        Task<TEntity> GetById(TKey id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>[] includes = null, CancellationToken cancellationToken = default);
        Task Add(TEntity entity, CancellationToken cancellationToken = default);
        Task Update(TEntity entity, CancellationToken cancellationToken = default);
        Task Delete(TEntity entity, CancellationToken cancellationToken = default);
    }
}
