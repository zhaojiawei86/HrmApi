using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Request
{
	public class EmployeeTypeRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string? description { get; set; }
        public bool IsActive { get; set; }
    }
}

