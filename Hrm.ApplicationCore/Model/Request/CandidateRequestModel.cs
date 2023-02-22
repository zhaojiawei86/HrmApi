using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Request
{
	public class CandidateRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string currentAddress { get; set; }
        public string? ResumeUrl { get; set; }
    }
}

