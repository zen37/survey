using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace survey.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int InterestId { get; set; }  // foreign key to Interests table
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Change { get; set; }
        public Interest Interest { get; set; }  // navigation property to Interests table
        public ICollection<Response> Responses { get; set; }
    }
}
