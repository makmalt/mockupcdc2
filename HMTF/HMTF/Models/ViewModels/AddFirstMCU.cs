﻿using System.ComponentModel.DataAnnotations;

namespace HMTF.Models.ViewModels
{
    public class AddFirstMCU
    {
        [Key]
        public string IdTransaction { get; set; }

        public int NIK { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FilePath { get; set; }
    }
}
