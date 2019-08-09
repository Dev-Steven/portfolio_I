using Microsoft.AspNetCore.Mvc;
namespace portfolio_I.Controllers     //be sure to use your own project's namespace!
{
    public class IndexController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("projects")]
        public ViewResult projects()
        {
            return View("Projects");
        }

        [HttpGet]
        [Route("contact")]
        public ViewResult contact()
        {
            return View("Contact");
        }
    }
}
