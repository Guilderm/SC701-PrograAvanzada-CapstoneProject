using BackEnd.DAL;
using BackEnd.Entities;
using BackEndAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansStateController : ControllerBase
    {
        private LoansStateDALImpl loansStatelDAL;

        public LoansStateController()
        {
            loansStatelDAL = new LoansStateDALImpl();
        }

        // GET: api/<LoansStateController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoansStateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoansStateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoansStateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoansStateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
