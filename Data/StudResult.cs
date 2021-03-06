﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCoreFirst.Data
{
    public class StudResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int RollNo { get; set; }
        [Required]
        public string StudName { get; set; }
        [Required]
        public string BoardName { get; set; }
        [Range(0,100)]
        public int M1 { get; set; }
        [Range(0, 100)]
        public int M2 { get; set; }
        [Range(0, 100)]
        public int M3 { get; set; }

        public int TotalMarks { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Greeting{ get; set; }
       
       


    }
}
