﻿using Libs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Libs.Domain.Repositories.Operations
{
    public interface ICreate<TEntity, out TPrimaryKey> 
        where TEntity : IEntity<TPrimaryKey>
        where TPrimaryKey: IEquatable<TPrimaryKey>
    {
        TPrimaryKey CreateAndGetId(TEntity entity);

        TEntity Create(TEntity entity);

        List<TEntity> CreateMany(params TEntity[] entities);

        List<TEntity> CreateMany(IEnumerable<TEntity> entities);
    }

    public interface ICreateAsync<TEntity, TPrimaryKey>
        where TEntity : IEntity<TPrimaryKey>
        where TPrimaryKey : IEquatable<TPrimaryKey>
    {

        Task<TPrimaryKey> CreateAndGetIdAsync(TEntity entity);

        Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task<List<TEntity>> CreateManyAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    }
}
