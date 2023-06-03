using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Document { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(9)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [Required]
        [MaxLength(9)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
