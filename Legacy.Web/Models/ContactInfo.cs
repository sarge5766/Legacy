﻿namespace Legacy.Web.Models {
    public class ContactInfo {
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string?  State { get; set; }
        public string?  Zipcode { get; set; }

        public List<SocialLink> SocialLinks { get; set; } = new List<SocialLink>();
    }
}
