﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseResultWebApp.Models
{
    public class Enroll
    {
        public int  CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime EnrollDate { get; set; }

    }
}