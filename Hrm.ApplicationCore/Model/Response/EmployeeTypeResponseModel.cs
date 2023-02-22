using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Response
{
	public class EmployeeTypeResponseModel
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string? description { get; set; }
        public bool IsActive { get; set; }
    }
}

