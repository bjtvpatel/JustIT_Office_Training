using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyStore.domainDB.Entities
{
    //shipping detail
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        [Display(Name = "House Number")]
        public string Line1 { get; set; }
        [Display(Name = "Street Name")]
        public string Line2 { get; set; }
        [Display(Name = "Address Line")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

       // [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Zip/Postal Code")]
        public string Postcode { get; set; }

        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}