using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularMVCCore
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private static string[] Nombres = new[]
        {
            "Jaimito", "Juanito", "Laurita", "Raulito", "Alvarito", "Fran", "Pablito", "Joselito", "Maria", "Amazon"
        };
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IEnumerable<ClienteUser> Get(int id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ClienteUser
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                Edad = rng.Next(18, 65),
                Nombre = Nombres[rng.Next(Nombres.Length)]
            });
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public class ClienteUser
        {
            public string DateFormatted { get; set; }
            public int Edad { get; set; }
            public string Nombre { get; set; }
        }
    }
}
