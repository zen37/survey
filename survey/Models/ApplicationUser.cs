namespace survey.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace YourProject.Models
    {
        public class ApplicationUser : IdentityUser
        {
            public string User { get; set; }
            [Column(TypeName = "nvarchar(2083)")]
            public string Linkedin { get; set; }
            [Column(TypeName = "nvarchar(2083)")]
            public string Facebook { get; set; }
            [Column(TypeName = "nvarchar(2083)")]
            public string Instagram { get; set; }
            [Column(TypeName = "nvarchar(2083)")]
            public string Other { get; set; }

            public ICollection<Response> Responses { get; set; }
        }
    }

}
