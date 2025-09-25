using CORE.APP.Domain;
using System.ComponentModel.DataAnnotations;

namespace Users.APP.Domain
{
    public class Group : Entity
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; } // varchar(100)
    }
}
