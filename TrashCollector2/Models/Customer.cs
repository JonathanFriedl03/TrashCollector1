using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector2.Models
{
    public class Customer
    {
        [Key] 
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Zip Code")]        
        public int ZipCode { get; set; }
        [Display(Name = "Pick Up Day")]
        public DayOfWeek PickUpDay { get; set; }
        [Display(Name = "One Time Pick Up")]
        public DayOfWeek OneTimePickUp { get; set; }
        [Display(Name = "Start of Suspension")]
        public DateTime StartOfSuspension { get; set; }
        [Display(Name = "End of Suspension")]
        public DateTime EndOfSupspension { get; set; }
        public double Budget { get; set; }

        [ForeignKey("IdentityUser")] 
        public string IdentityUserId { get; set; }
    public IdentityUser IdentityUser { get; set; }
    }
}
