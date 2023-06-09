﻿using System.Data;

namespace Marketplace.Application.Models.GenericRepository;

public interface IUnitOfWork : IDisposable
{
    IDbConnection Connection { get; }

    IDbTransaction Transaction { get; }
}
