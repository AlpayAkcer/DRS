using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DRS.Entity
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public DateTime CreatDate { get; set; }

        public DateTime UpdateDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string Description { get; set; }

        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
    }
}