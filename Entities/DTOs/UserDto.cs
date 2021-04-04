﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerId { get; set; }

    }
}
