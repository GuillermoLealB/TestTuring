using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomersTest.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CustomersTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerContext _dbcontext;

        public CustomerController(CustomerContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpPost]
        [Route("Save")]
        public IActionResult Save([FromBody] InfCustomer obj)
        {
            try { 
                _dbcontext.InfCustomers.Add(obj);
                _dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }
            catch (Exception ex) { return StatusCode(StatusCodes.Status200OK, new { menssage = ex.Message }); }
        }

    }
}
