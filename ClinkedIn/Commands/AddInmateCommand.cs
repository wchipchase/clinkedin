﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace ClinkedIn.Commands
{
    public class AddInmateCommand
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string CrimeCharged { get; set; }
        public DateTime ConvictedDate { get; set; }
        public int LengthOfSentence { get; set; }
        public List<string> MyServices { get; set; }
        public List<string> Crew { get; set; }
        public List<string> Clique { get; set; }
        public List<string> Beefs { get; set; }
        public List<string> Interests { get; set; }
    }
}
