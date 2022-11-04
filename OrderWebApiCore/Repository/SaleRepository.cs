using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using Microsoft.Extensions.Configuration;
using OrderWebApiCore.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private readonly IConfiguration configuration;
        public SaleRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<int> AddAsync(Sale entity)
        {
           
            var sql = "Insert into Sales (ProductID,CustomerID, SalePrice, SaleDate) VALUES (@ProductID,@CustomerID,@SalePrice,@SaleDate)";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();

            var sql = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Sale>> GetAllAsync()
        {
          
            var sql = "SELECT * FROM Sales";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Sale>(sql);
                return result.ToList();
            }
        }

        public async Task<Sale> GetByIdAsync(int? id)
        {
         
            var sql = "SELECT * FROM sales WHERE SaleId = @SaleId";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Sale>(sql, new { SaleId = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Sale entity)
        {
            throw new NotImplementedException();

            var sql = "UPDATE Products SET ProductName = @ProductName, Category = @Category,  RecommendedPrice = @RecommendedPrice WHERE ProductID = @ProductID";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
    }
}
