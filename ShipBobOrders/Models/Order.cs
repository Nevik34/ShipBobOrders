using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShipBobOrders.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        [Display(Name = "Tracking ID")]
        public string TrackingID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public virtual User User { get; set; }
    }
}