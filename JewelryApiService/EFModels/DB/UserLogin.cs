using System;
using System.Collections.Generic;

#nullable disable

namespace JewelryApiService.EFModels.DB
{
    public partial class UserLogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserPrivilage { get; set; }
    }
}
