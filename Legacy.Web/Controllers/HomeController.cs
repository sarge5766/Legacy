using Legacy.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Legacy.Web.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration) {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Navbar() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "About Us";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");


            return View(contactInfo);
        }

        public IActionResult AboutUs() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "About Us";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult ContactUs() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Contact Us";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult Costs() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Costs";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult CounselingServices() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Counseling Services";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult Index() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Home";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult KeyStats() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Key Statistics";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult OurMission() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Our Mission";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult Presentation() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Presentation";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult PresentationPageTwo() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Presentation";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult Privacy() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Privacy Statement";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult PropertyManagement() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Property Management";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult ResidentialServices() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Residential Services";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult Services() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Services";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        public IActionResult Statistics() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Statistics";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }
        public IActionResult Testimonials() {
            var contactInfo = GetContactInfo();

            ViewData["Title"] = "Testimonials";
            ViewData["SiteTitle"] = _configuration.GetValue<string>("SiteTitle");
            ViewData["CompanyName"] = _configuration.GetValue<string>("CompanyName");

            return View(contactInfo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private ContactInfo GetContactInfo() {
            ContactInfo contactInfo = new() {
                Address = _configuration.GetValue<string>("ContactInfo:Address"),
                City = _configuration.GetValue<string>("ContactInfo:City"),
                Email = _configuration.GetValue<string>("ContactInfo:Name"),
                Name = _configuration.GetValue<string>("ContactInfo:Name"),
                PhoneNumber = _configuration.GetValue<string>("ContactInfo:PhoneNumber"),
                State = _configuration.GetValue<string>("ContactInfo:State"),
                Zipcode = _configuration.GetValue<string>("ContactInfo:Zipcode")
            };

            contactInfo.SocialLinks.Add(new SocialLink {
                Name = "Facebook",
                Url = _configuration.GetSection("SocialMediaLinks").GetSection("Facebook").Value
            });

            contactInfo.SocialLinks.Add(new SocialLink {
                Name = "Twitter",
                Url = _configuration.GetSection("SocialMediaLinks").GetSection("Twitter").Value
            });

            //var facebook = _configuration.GetSection("SocialMediaLinks").GetSection("Facebook").Value;
            //var twitter = _configuration.GetSection("SocialMediaLinks").GetSection("Twitter").Value;

            return contactInfo;
        }
    }
}
