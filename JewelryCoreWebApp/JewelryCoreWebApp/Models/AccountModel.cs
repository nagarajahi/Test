using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryCoreWebApp.Models
{
    public class AccountModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        public string UserProfile { get; set; }
    }
}
