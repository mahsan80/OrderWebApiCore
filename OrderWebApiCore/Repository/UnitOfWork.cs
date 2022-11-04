using Dapper.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(IProductRepository productRepository, ICustomerRepository customers, ISaleRepository sale)
        {
            Products = productRepository;
            Customers = customers;
            Sales = sale;
        }
        public IProductRepository Products { get; }
        public ICustomerRepository Customers { get; }

        public ISaleRepository Sales { get; }
    }
}
