using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Models
{
    public class Inmate

        
    {
        public int id { get; set; }

        public string Name { get; set; }
        public string CrimeCharged { get; set; }
        public DateTime DischargeDate { get; set; }
        public List<string> MyServices{ get; set; }
        public List<string> Crew { get; set; }
        public List<string> Clique { get; set; }
        public List<string> Beefs { get; set; }
        public List<string> Interests { get; set; }
    }
    
}
