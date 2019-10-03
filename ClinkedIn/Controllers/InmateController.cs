using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Commands;
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
        public ActionResult<Inmate> GetById(int id)
        {
            var repo = new InmateRepository();
            return repo.Get(id);
        }

        // Get: api/Inmate/interest
        [HttpGet("interest/{interest}")]
        public ActionResult<IEnumerable<Inmate>> GetListOfInmatesByInterest(string interest)
        {
            var repo = new InmateRepository();
            return Ok(repo.GetListOfInmatesByInterest(interest));
        }

        // POST: api/Inmate
        [HttpPost]
        public IActionResult CreateInmate(AddInmateCommand newInmateCommand)
        {
            var newInmate = new Inmate
            {
                id = newInmateCommand.id,
                Name = newInmateCommand.Name,
                DischargeDate = newInmateCommand.DischargeDate,
                CrimeCharged = newInmateCommand.CrimeCharged,
                Crew = newInmateCommand.Crew,
                Clique = newInmateCommand.Clique,
                Beefs = newInmateCommand.Beefs,
                Interests = newInmateCommand.Interests,
            };
            var repo = new InmateRepository();
            var inmateThatGotCreated = repo.Add(newInmate);

            return Created($"api/Inmate/{inmateThatGotCreated.Name}", inmateThatGotCreated);
        }

        // PUT: api/Inmate/5
        [HttpPut("{id}")]
        public IActionResult UpdateInmate(UpdateInmateCommand updatedInmateCommand, int id)
        {
            var repo = new InmateRepository();
            var updatedInmate = new Inmate
            {
                Name = updatedInmateCommand.Name,
                DischargeDate = updatedInmateCommand.DischargeDate,
                CrimeCharged = updatedInmateCommand.CrimeCharged,
                Crew = updatedInmateCommand.Crew,
                Clique = updatedInmateCommand.Clique,
                Beefs = updatedInmateCommand.Beefs,
                Interests = updatedInmateCommand.Interests,
            };

            var inmateThatGotUpdated = repo.Update(updatedInmate, id);
            return Ok(inmateThatGotUpdated);
        }

        [HttpGet("mycrews/{id}")]
        public ActionResult<Inmate> GetMyCrews(int id)
        {
            var repo = new InmateRepository();
            var myCrews = repo.GetFriendsFriend(id);
            return myCrews;
        }
    }
}
