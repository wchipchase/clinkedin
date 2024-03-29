﻿using System;
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
                ConvictedDate = newInmateCommand.ConvictedDate,
                LengthOfSentence = newInmateCommand.LengthOfSentence,
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
                ConvictedDate = updatedInmateCommand.ConvictetdDate,
                LengthOfSentence = updatedInmateCommand.LenghtOfSentence,
                CrimeCharged = updatedInmateCommand.CrimeCharged,
                Crew = updatedInmateCommand.Crew,
                Clique = updatedInmateCommand.Clique,
                Beefs = updatedInmateCommand.Beefs,
                Interests = updatedInmateCommand.Interests,
            };

            var inmateThatGotUpdated = repo.Update(updatedInmate, id);
            return Ok(inmateThatGotUpdated);
        }

        // PUT: api/Inmate/id/interest
        [HttpPut("{id}/interest")]
        public IActionResult UpdateInmateInterest(UpdateInterestCommand updateInterestCommand, int id)
        {
            var repo = new InmateRepository();

            var inmateInterestGotUpdated = repo.updateInmateInterest(updateInterestCommand.Interests, id);
            return Ok(inmateInterestGotUpdated);
        }

        [HttpGet("{id}/myservices")]
        public ActionResult<IEnumerable<string>> GetInmateServices(int id)
        {
            var repo = new InmateRepository();
            try
            {
                var myServices = repo.GetMyServices(id);
                return myServices;
            }
            catch (Exception)
            {
                return BadRequest("Inmate ID does not exist");
            }

        }

        [HttpGet("{id}/beefs")]
        public ActionResult<IEnumerable<string>> GetInmateBeefs(int id)
        {
            try
            {
                var repo = new InmateRepository();
                var myBeefs = repo.GetMyBeefs(id);
                return myBeefs;
            }
            catch(Exception)
            {
                return BadRequest("Inmate ID does not exist");
            }

        }

        [HttpGet("{id}/friends")]
        public ActionResult<IEnumerable<string>> GetMyFriends(int id)
        {
            try
            {
                var repo = new InmateRepository();
                var myFriends = repo.GetMyFriends(id);
                return myFriends;
            }
            catch (Exception)
            {
                return BadRequest("Inmate ID does not exist");
            }
        }

        [HttpGet("{id}/sentence")]
        public ActionResult<int> GetDaysLeftInSentence(int id)
        {
            var repo = new InmateRepository();
            var inmate = repo.Get(id);
            var today = DateTime.Now;
            TimeSpan daysServed = inmate.ConvictedDate - today;
            var daysServedAbs = Math.Abs(daysServed.Days);
            var daysLeft = (inmate.LengthOfSentence - daysServedAbs);
            return daysLeft;
        }


        [HttpGet("{id}/mycrews")]
        public ActionResult<List<string>> GetMyCrews(int id)
        {
            try
            {
                var repo = new InmateRepository();
                var myCrews = repo.GetFriendsFriend(id);
                return myCrews;
            }
            catch (Exception)
            {
                return BadRequest("Inmate ID does not exist");
            }
        }
    }
}
