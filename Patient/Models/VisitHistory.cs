using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patient.Models
{
    public class VisitHistory
    {
        public int Id { get; set; }
        public string Patient { get; set; }
        public string FIODoctor { get; set; }
        public string Diagnosis { get; set; }
        public string Comlaint { get; set; }
        public DateTime Date { get; set; }
    }
}