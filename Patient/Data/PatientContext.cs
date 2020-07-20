using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Patient.Data
{
    public class PatientContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PatientContext() : base("name=PatientContext")
        {
        }

        public System.Data.Entity.DbSet<Patient.Models.Patients> Patients { get; set; }

        public System.Data.Entity.DbSet<Patient.Models.VisitHistory> VisitHistories { get; set; }
    }
}
