using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitleContent_Management.Models
{
    public class Document
    {
        public Guid DocumentId { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentExtention { get; set; }
        public double DocumentSize { get; set; }
        public string FileLocation { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string UseId { get; set; }
    }
}
