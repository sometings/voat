//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Survey
    {
        public string Username { get; set; }
        public bool Interested_in_content_creation { get; set; }
        public bool Interested_in_commenting { get; set; }
        public bool Interested_in_donating_earnings { get; set; }
        public string Preferred_payment_method { get; set; }
        public bool Interested_in_bitcoin_payout { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public System.DateTime Date_submitted { get; set; }
        public bool Wants_to_be_contacted_at_service_launch { get; set; }
        public string Email { get; set; }
        public bool Wants_to_subscribe_to_whoaverse_news { get; set; }
    }
}