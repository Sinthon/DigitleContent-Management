using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitleContent_Management.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Commune { get; set; }
        public string Village { get; set; }

        [ForeignKey(nameof(Lecturer))]
        public string LecturerId { get; set; }

        //[InverseProperty("LecturerDobAddress")]
        //public Lecturer LecturerDobAddress { get; set; }
        //[InverseProperty("LecturerPobAddress")]
        //public Lecturer LecturerPobAddress { get; set; }
    }
}
