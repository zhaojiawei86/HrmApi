﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Response
{
	public class UserResponseModel
	{
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}

