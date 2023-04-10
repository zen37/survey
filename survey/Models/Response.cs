using survey.Models.YourProject.Models;

namespace survey.Models
{
    public class Response
    {
        public int Id { get; set; }
        public bool Answer { get; set; }
        public DateTime DateTimeSubmitted { get; set; }
        public int QuestionId { get; set; }  // foreign key to the Question table
        public string UserId { get; set; }  // foreign key to the ApplicationUser table
        public virtual ApplicationUser User { get; set; }
        public virtual Question Question { get; set; }
    }

}
