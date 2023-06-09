﻿using System;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public partial class StudentDeets
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RollNo { get; set; }
        public string Address { get; set; } = null!;
        //public StudentDeets() { }
        public string FamilyName { get; set; } = null!; 
        public long Contact { get; set; }
    }
}
