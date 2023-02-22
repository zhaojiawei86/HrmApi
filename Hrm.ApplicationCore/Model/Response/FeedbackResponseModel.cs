using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Response
{
	public class FeedbackResponseModel
	{
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public string Description { get; set; }
    }
}

