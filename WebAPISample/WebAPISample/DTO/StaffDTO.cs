﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample.DTO
{
    public class StaffDTO
    {
        public long Id { get; set; }

        public String Name { get; set; }

        public UserDTO UserAccount { get; set; }
    }
}