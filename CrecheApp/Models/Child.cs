using System;
using System.ComponentModel.DataAnnotations;

namespace CrecheApp.Models
{
    public class Child
    {   //child constructors
        [Required] public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = "";

        [Required]
        [Display(Name = "PPS Number")]
        public string PpsId { get; set; } = "";

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender ChildGender { get; set; }
        public enum Gender
        {
            Male,
            Female
        }

        [Required]
        [Display(Name = "Monday")]
        public bool Monday { get; set; }

        [Required]
        [Display(Name = "Tuesday")]
        public bool Tuesday { get; set; }

        [Required]
        [Display(Name = "Wednesday")]
        public bool Wednesday { get; set; }

        [Required]
        [Display(Name = "Thursday")]
        public bool Thursday { get; set; }

        [Required]
        [Display(Name = "Friday")]
        public bool Friday { get; set; }


        [Required]
        [Display(Name = "Full or Part Time")]
        public string FullOrPart { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "Parent First Name")]
        public string ParentFirstName { get; set; } = "";

        [Required]
        [Display(Name = "Parent Last Name")]
        public string ParentLastName { get; set; } = "";

        [Required]
        [Display(Name = "Relationship")]
        public Relationship ChildRelationship { get; set; }
        public enum Relationship
        {
            Mother,
            Father,
            Other
        }

        [Required] public string Address1 { get; set; } = "";

        [Required] public string Address2 { get; set; } = "";

        [Required] public string Town { get; set; } = "";

        [Required] public string County { get; set; } = "";

        [Required] public string Eircode { get; set; } = "";

        [Required]
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }

        [Display(Name = "2nd Mobile")]
        public string Mobile2 { get; set; }

        [Display(Name = "Other Number")]
        public string OtherPhone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "2nd E-mail")]
        public string Email2 { get; set; }

        public int DaysRequested { get; set; }

    }

}
