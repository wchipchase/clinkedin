using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.DataAccess;
using ClinkedIn.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn.Controllers
{
    [Route("api/Inmate")]
    [ApiController]
    public class InmateController : ControllerBase
    {
        // GET: api/Inmate
        [HttpGet]
        public ActionResult<IEnumerable<Inmate>> Get()
        {
            var repo = new InmateRepository();
            return repo.GetAll();
        }

        // GET: api/Inmate/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Inmate
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Inmate/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
