using Microsoft.AspNetCore.Mvc;
namespace portfolio_I.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet]
        [Route("projects")]
        public string projects()
        {
            return "These are my Projects!";
        }

        [HttpGet]
        [Route("contact")]
        public string contact()
        {
            return "This is my Contact!";
        }
    }
}
