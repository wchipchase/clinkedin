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
    [Route("api/inmates")]
    [ApiController]
    public class InmateController : ControllerBase
    {



        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var repo = new InmateRepository();
            var myServ = repo.GetMyServices();
            return myServ;
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
