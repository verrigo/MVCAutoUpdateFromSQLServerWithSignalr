using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAutoUpdateFromSQLServerWithSignalr.Models
{
    public class SalesNotifications
    {
        [HiddenInput] 
        public int Id { get; set; }
        public string ProductName { get; set; }
        [Range(0, 1000000000,
            ErrorMessage = "Quantity must be at least zero")]
        public int Quantity { get; set; }
        public bool SalesNotificationRead { get; set; }
    }
}