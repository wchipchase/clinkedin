using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinkedIn.Commands;
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
                ConvictedDate = new DateTime(2019, 09, 09),
                LengthOfSentence = 7300,
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
                ConvictedDate = new DateTime(2015, 09, 09),
                LengthOfSentence = 1800,
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
                ConvictedDate = new DateTime(2019, 09, 09),
                LengthOfSentence = 2000,
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
                ConvictedDate = new DateTime(2017, 09, 09),
                LengthOfSentence = 3000,
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
                ConvictedDate = new DateTime(2013, 09, 09),
                LengthOfSentence = 9000,
                CrimeCharged = "Poltics",
                MyServices = new List<string> {"Hoochmaster"} ,
                Crew = new List<string>{ },
                Clique = new List<string>{"Saul Solano", "Silvestre Luna", "Nathan Gonzalez"},
                Beefs = new List<string>{ "Bill Billingsley", "Tom Thompson"},
                Interests = new List<string>{ "Reading", "Music", "Weightlifting"}
            },

            new Inmate
            {
                id = 6,
                Name = "Bob Bobertson",
                ConvictedDate = new DateTime(2014, 09, 09),
                LengthOfSentence = 60000,
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
                ConvictedDate = new DateTime(2016, 09, 09),
                LengthOfSentence = 60000,
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
                ConvictedDate = new DateTime(2017, 09, 13),
                LengthOfSentence = 60000,
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
                ConvictedDate = new DateTime(2019, 08, 29),
                LengthOfSentence = 17000,
                CrimeCharged = "Murder 3",
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
                ConvictedDate = new DateTime(2019, 07, 19),
                LengthOfSentence = 5000,
                CrimeCharged = "Murder 3",
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
            var inmate = _inmates.FirstOrDefault(t => t.id == id);
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
            inmateToUpdate.ConvictedDate = updatedInmate.ConvictedDate;
            inmateToUpdate.LengthOfSentence = updatedInmate.LengthOfSentence;
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
        
        public Inmate updateInmateInterest(List<string> updatedInterests, int id) 
        {
            var inmateInterestUpdate = _inmates.FirstOrDefault(inmate => inmate.id == id);
            inmateInterestUpdate.Interests.AddRange(updatedInterests);
            return inmateInterestUpdate;
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

        public List<string> GetMyFriends(int id)
        {
            var myFriends = _inmates.FirstOrDefault(t => t.id == id);
            if (myFriends == null)
            {
                throw new Exception();
            }
            return myFriends.Clique;
        }

    }
}
