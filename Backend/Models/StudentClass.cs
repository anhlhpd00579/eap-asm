﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class StudentClass
    {
        public StudentClass()
        {
            this.StartDate = DateTime.Now;
            this.StudentClassStatus = StudentClassStatus.Active;
        }
        [Key]
        public string StudentClassId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public string Session { get; set; }
        public StudentClassStatus StudentClassStatus { get; set; }
        [Required]
        public int CurrentSubjectId { get; set; }
        public Subject Subject { get; set; }
    }

    public enum StudentClassStatus
    {
        Active = 1,
        Deactive = 0
    }
}
