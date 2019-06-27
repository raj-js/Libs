﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Libs.Infrastructure.Paging;

namespace Libs.Domain.Repositories.Operations
{
    public interface IPaging<TEntity, in TKey>
        where TEntity : class
        where TKey : IEquatable<TKey>
    {
        IPageResult<TEntity> Paging(IPageQuery<TEntity> query);
    }
     
    public interface IPagingAsync<TEntity, in TKey>
        where TEntity : class 
        where TKey : IEquatable<TKey> 
    {
        Task<IPageResult<TEntity>> PagingAsync(IPageQuery<TEntity> query, CancellationToken cancellationToken = default);
    }
} 
