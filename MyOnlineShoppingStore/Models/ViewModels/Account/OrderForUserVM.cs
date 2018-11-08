using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyOnlineShoppingStore.Models.ViewModels.Account
{
    public class OrderForUserVM
    {
        
        public int OrderNumber { get; set; }
        public decimal Total { get; set; }
        [Key]
        public Dictionary<string, int> ProductAndQty { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
