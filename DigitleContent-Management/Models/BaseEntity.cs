using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitleContent_Management.Models
{
    public class BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string FatherJob { get; set; }
        public string MotherName { get; set; }
        public string MotherJob { get; set; }
        public DateTime DateOfBirth { get; set; }
        [NotMapped]
        public int Age { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ProfileImage { get; set; }
    }
}
