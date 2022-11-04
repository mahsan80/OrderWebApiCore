using Dapper.Core.Entities;
using OrderWebApiCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Application.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }

    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }

    public interface ISaleRepository : IGenericRepository<Sale>
    {
    }
}
