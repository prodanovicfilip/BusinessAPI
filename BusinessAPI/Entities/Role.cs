﻿using System.ComponentModel.DataAnnotations;

namespace BusinessAPI.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
