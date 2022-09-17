using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StarterKitAspNetCoreWebApp.Controllers
{
    public class PagesController: Controller
    {
   private readonly ILogger<PagesController> _logger;
         public PagesController(ILogger<PagesController> logger)
        {
            _logger = logger;
        }

    
    [Route("Pages/widgets")]
        public IActionResult widgets()
        {
            return View();
        }


         [Route("Pages/top_nav")]
        public IActionResult top_nav()
        {
            return View();
        }
		
		[Route("Pages/top_nav_sidebar")]
        public IActionResult top_nav_sidebar()
        {
            return View();
        }

        [Route("Pages/boxed")]
        public IActionResult boxed()
        {
            return View();
        }

        [Route("Pages/fixed_sidebar")]
        public IActionResult fixed_sidebar()
        {
            return View();
        }

        [Route("Pages/fixed_topnav")]
        public IActionResult fixed_topnav()
        {
            return View();
        }

        [Route("Pages/fixed_footer")]
        public IActionResult fixed_footer()
        {
            return View();
        }


        [Route("Pages/collapsed_sidebar")]
        public IActionResult collapsed_sidebar()
        {
            return View();
        }

        
    }
}