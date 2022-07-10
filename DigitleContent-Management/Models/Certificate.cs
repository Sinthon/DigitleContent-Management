using DigitleContent_Management.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitleContent_Management.Models
{
    public class Certificate
    {
        public Guid CertificateId { get; set; }
        public List<Degree> Degrees { get; set; }
        public DateTime GraduatedOn { get; set; }
    }
}
