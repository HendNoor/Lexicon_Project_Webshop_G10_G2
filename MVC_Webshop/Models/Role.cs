﻿using System.ComponentModel.DataAnnotations;

namespace MVC_Webshop.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
