using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryApiService.Models
{
    public class User
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "pwd")]
        public string UserPassword { get; set; }

        public string Privilage { get; set; }
    }
}
