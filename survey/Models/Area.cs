using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace survey.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Change { get; set; }

        public ICollection<Interest> Interests { get; set; }
    }

}
