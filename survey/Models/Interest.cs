using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace survey.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Change { get; set; }
        public Area Area { get; set; }
        public ICollection<Question> Questions { get; set; }  // navigation property to Questions table
    }
}
