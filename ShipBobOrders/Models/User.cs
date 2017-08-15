using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShipBobOrders.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "User")]
        public string FullName {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public virtual ICollection<Order> Orders { get; set; }
    }
}