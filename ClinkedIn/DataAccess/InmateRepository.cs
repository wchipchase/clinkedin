using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;

namespace ClinkedIn.DataAccess
{
    public class InmateRepository
    {
        static List<Inmate> _inmates = new List<Inmate>
        {
            {
                id = Guid.NewGuid(),
                Name = "Nathan Gonzalez",
                DischargeDate = 06/20/2099,
                CrimeCharged = "Murder 1",
                Services = _inmates.Services ("Hoochmaster") ,
                Service
                Crew = 0
                Clique = 
                Beefs = 
                Interests = 
            },

            new Inmate
            {
                id = Guid.NewGuid(),
                Name = "Martin Cross",
                DischargeDate = 06/20/2099,
                CrimeCharged = "Murder 1"
                Services = Specialty.TaeCluckDoe,
                Crew = 0
                Clique =
                Beefs =
                Interests =
            },

            new Inmate
            {
                id = Guid.NewGuid(),
                Name = "Nathan",
                DischargeDate = 06/20/2099,
                CrimeCharged = "Murder 1"
                Services = Specialty.TaeCluckDoe,
                Crew = 0
                Clique =
                Beefs =
                Interests =
            }

            new Inmate
            {
                id = Guid.NewGuid(),
                Name = "Nathan",
                DischargeDate = 06/20/2099,
                CrimeCharged = "Murder 1"
                Services = Specialty.TaeCluckDoe,
                Crew = 0
                Clique =
                Beefs =
                Interests =
            }

        };

        internal ActionResult<Trainer> Get()
        {
            throw new NotImplementedException();
        }

        public List<Trainer> GetAll()
        {
            return _trainers;
        }

        public Trainer Get(string name)
        {
            var trainer = _trainers.First(t => t.Name == name);
            return trainer;
        }

        public void Remove(string name)
        {
            var trainer = Get(name);
            _trainers.Remove(trainer);
        }

        public Trainer Update(Trainer updatedTrainer, Guid id)
        {
            var trainerToUpdate = _trainers.First(trainer => trainer.id == id);
            trainerToUpdate.Name = updatedTrainer.Name;
            trainerToUpdate.YearsOfExperience = updatedTrainer.YearsOfExperience;
            trainerToUpdate.Specialty = updatedTrainer.Specialty;
            return trainerToUpdate;
        }

        public Trainer Add(Trainer newTrainer)
        {
            _trainers.Add(newTrainer);
            return newTrainer;
        }
    }
}
