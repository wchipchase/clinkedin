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

        public ActionResult<Inmate> GetById(int id)
            var repo = new InmateRepository();
            return repo.Get(id);

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

        [HttpGet("myservices/{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
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
    }
}
