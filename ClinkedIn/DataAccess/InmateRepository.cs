using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinkedIn.DataAccess
{
    public class InmateRepository
    {
        static List<Inmate> _inmates = new List<Inmate>
        {
            new Inmate
            {
                id = 1,
                Name = "Nathan Gonzalez",
                DischargeDate = new DateTime(),
                CrimeCharged = "Public Intoxication",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{""},
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Martin Cross",
                DischargeDate = new DateTime(05/15/2024),
                CrimeCharged = "Reckless Endangerment",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Silvestre Luna",
                DischargeDate = new DateTime(09/20/2025),
                CrimeCharged = "Indecent Exposure",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Saul Soldano",
                DischargeDate = new DateTime(01/12/2029),
                CrimeCharged = "Assault and Battery",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

                        new Inmate
            {
                id = 1,
                Name = "Wayne Chipchase",
                DischargeDate = new DateTime(06/13/2050),
                CrimeCharged = "Poltics",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Bob Bobertson",
                DischargeDate = new DateTime(08/11/2099),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Bill Billingsley",
                DischargeDate = new DateTime(06/20/2099),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Tom Thompson",
                DischargeDate = new DateTime(06/20/2099),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Fred Fredrickson",
                DischargeDate = new DateTime(06/20/2099),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },

            new Inmate
            {
                id = 1,
                Name = "Stew Stewart",
                DischargeDate = new DateTime(06/20/2099),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"" },
                Beefs = new List<string>{ ""},
                Interests = new List<string>{ ""}
            },
        };

        public List<Inmate> GetAll()
        {
            return _inmates;
        }

        public Inmate Get(int id)
        {
            var inmate = _inmates.First(t => t.id == id);
            return inmate;
        }

        public void Remove(int id)
        {
            var inmate = Get(id);
            _inmates.Remove(inmate);
        }

        public Inmate Update(Inmate updatedInmate, int id)
        {
            var inmateToUpdate = _inmates.First(inmate => inmate.id == id);
            inmateToUpdate.Name = updatedInmate.Name;
            inmateToUpdate.DischargeDate = updatedInmate.DischargeDate;
            inmateToUpdate.CrimeCharged = updatedInmate.CrimeCharged;
            inmateToUpdate.Beefs = updatedInmate.Beefs;
            inmateToUpdate.Clique = updatedInmate.Clique;
            inmateToUpdate.Crew = updatedInmate.Crew;
            inmateToUpdate.Interests = updatedInmate.Interests;
            inmateToUpdate.MyServices = updatedInmate.MyServices;
            return inmateToUpdate;
        }

        public Inmate Add(Inmate newInmate)
        {
            _inmates.Add(newInmate);
            return newInmate;
        }
    }
}
