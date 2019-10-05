using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                DischargeDate = new DateTime(2099, 09, 09),
                CrimeCharged = "Public Intoxication",
                MyServices = new List<string> {"Hoochmaster", "Shankmaking"} ,
                Crew = new List<string>{},
                Clique = new List<string>{"Bob Bobertson", "Saul Solano" },
                Beefs = new List<string>{ "Tom Thompson"},
                Interests = new List<string>{ "Reading", "Music", "Cooking"}
            },

            new Inmate
            {
                id = 2,
                Name = "Martin Cross",
                DischargeDate = new DateTime(2024, 06, 15),
                CrimeCharged = "Reckless Endangerment",
                MyServices = new List<string> {"Shankmaster"} ,
                Crew = new List<string>{},
                Clique = new List<string>{"Wayne Chipchase", "Tom Thompson"  },
                Beefs = new List<string>{ "Saul Solano"},
                Interests = new List<string>{ "Reading", "Gardening"}
            },

            new Inmate
            {
                id = 3,
                Name = "Silvestre Luna",
                DischargeDate = new DateTime(2025, 09, 15),
                CrimeCharged = "Indecent Exposure",
                MyServices = new List<string> {"Bookie"} ,
                Crew = new List<string>{ },
                Clique = new List<string>{"Saul Solano", "Wayne Chipchase", "Nathan Gonzalez" },
                Beefs = new List<string>{ "Fred Fredrickson"},
                Interests = new List<string>{ "Chess", "Dice"}
            },

            new Inmate
            {
                id = 4,
                Name = "Saul Solano",
                DischargeDate = new DateTime(2029, 01, 02),
                CrimeCharged = "Assault and Battery",
                MyServices = new List<string> {"Personal Protection"} ,
                Crew = new List<string>{ },
                Clique = new List<string>{"Silvestre Luna", "Wayne Chipchase", "Martin Cross" },
                Beefs = new List<string>{ "Tom Thompson"},
                Interests = new List<string>{ "Drawing", "Music", "Reading"}
            },

                        new Inmate
            {
                id = 5,
                Name = "Wayne Chipchase",
                DischargeDate = new DateTime(2050, 06, 13),
                CrimeCharged = "Poltics",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{ },
                Clique = new List<string>{"Saul Solano", "Silvestre Luna", "Nathan Gonzalez"},
                Beefs = new List<string>{ "Bill Billingsley", "Bill Billingsley"},
                Interests = new List<string>{ "Reading", "Music", "Weightlifting"}
            },

            new Inmate
            {
                id = 6,
                Name = "Bob Bobertson",
                DischargeDate = new DateTime(2099, 08, 11),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Shankmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"Bill Billingsley", "Saul Solano"},
                Beefs = new List<string>{ "Silvestre Luna"},
                Interests = new List<string>{ "Reading", "Music", "Cooking" }
            },

            new Inmate
            {
                id = 7,
                Name = "Bill Billingsley",
                DischargeDate = new DateTime(2099, 06, 20),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Bookie"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"Wayne Chipchase", "Tom Thompson" },
                Beefs = new List<string>{ "Saul Solano"},
                Interests = new List<string>{ "Reading", "Gardening" }
            },

            new Inmate
            {
                id = 8,
                Name = "Tom Thompson",
                DischargeDate = new DateTime(2099, 06, 20),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Personal Protection"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"Saul Solano", "Silvestre Luna", "Nathan Gonzalez" },
                Beefs = new List<string>{ "MArtin Cross"},
                Interests = new List<string>{  "Reading", "Music", "Weightlifting"}
            },

            new Inmate
            {
                id = 9,
                Name = "Fred Fredrickson",
                DischargeDate = new DateTime(2099, 06, 20),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{"" },
                Clique = new List<string>{"Stew Stewart", "Tom Thompson" },
                Beefs = new List<string>{ "Nathan Gonzalez"},
                Interests = new List<string>{ "Chess", "Dice" }
            },

            new Inmate
            {
                id = 10,
                Name = "Stew Stewart",
                DischargeDate = new DateTime(2099, 06, 20),
                CrimeCharged = "Murder 1",
                MyServices = new List<string> {"Shankmaster"} ,
                Crew = new List<string>{ },
                Clique = new List<string>{"Tom Thompson", "Fred Fredrickson" },
                Beefs = new List<string>{ "Silvestre Luna"},
                Interests = new List<string>{ "Drawing", "Music", "Reading" }
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

        public List<string> GetListOfInmatesByInterest(string interest)
        {
            var userWithSpecificInterest = new List<string>();
            foreach(var inmate in _inmates)
            {
                if (inmate.Interests.Contains(interest))
                {
                    userWithSpecificInterest.Add(inmate.Name);
                }
            }
            return userWithSpecificInterest;
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

        public List<string> GetMyServices(int id)
        {
            var myServices = _inmates.FirstOrDefault(a => a.id == id);
            if (myServices == null)
            {
                throw new Exception();
            }
            return myServices.MyServices;
        }

        public List<string> GetMyBeefs(int id)
        {
            var myBeefs = _inmates.FirstOrDefault(t => t.id == id);
            if (myBeefs == null)
            {
                throw new Exception();
            }
            return myBeefs.Beefs;
        }

        public Inmate GetFriendsFriend(int id)
        {
            var something = Get(id);
            return something;
        }
    }
}
