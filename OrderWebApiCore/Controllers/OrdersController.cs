using Dapper.Application.Interfaces;
using Dapper.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using OrderWebApiCore.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public OrdersController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


      
        [HttpGet]
        [Route("api/GetProducts")]
        public async Task<IActionResult> GetProducts(int? id)
        {
            if (id == null)
            {
                var data = await unitOfWork.Products.GetAllAsync();
                return Ok(data);
                
            }
            else
            {
                var data = await unitOfWork.Products.GetByIdAsync(id);
                return Ok(data);
            }
        }


        [HttpGet]
        [Route("api/GetCustomers")]
        public async Task<IActionResult> GetCustomers(int? id)
        {
            if (id == null)
            {
                var data = await unitOfWork.Customers.GetAllAsync();
                return Ok(data);

            }
            else
            {
                var data = await unitOfWork.Customers.GetByIdAsync(id);
                return Ok(data);
            }
        }

        [HttpPost]
        [Route("api/CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] Sale sale)
        {
            var data = await unitOfWork.Sales.AddAsync(sale);
            return Ok(data);
        }

        [HttpGet]
        [Route("api/GetSales")]
        public async Task<IActionResult> GetSales(int? id)
        {
            if (id == null)
            {
                var data = await unitOfWork.Sales.GetAllAsync();
                return Ok(data);

            }
            else
            {
                var data = await unitOfWork.Sales.GetByIdAsync(id);
                return Ok(data);
            }
        }
        // POST api/<OrdersController>
        [HttpPost]
       
        public void PostOrder([FromBody] Sale sale)
        {

        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
