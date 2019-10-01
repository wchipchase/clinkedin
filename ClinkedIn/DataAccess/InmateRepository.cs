using ClinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.DataAccess
{
    public class InmateRepository
    {
        static List<Inmate> _inmates = new List<Inmate>
        {
            new Inmate
            {
                Name = "Joe",
                MyServices = new List<string>{"Saul", "Silvestre"}

            }
        };

        public List<string> GetMyServices()
        {
            return _inmates.First().MyServices;
        }

    }
}
