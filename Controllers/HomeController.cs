using Microsoft.AspNetCore.Mvc;

namespace testnetcore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hei hei!";
        }

        // Or we can define routes on the method and class level.
        [Route("/")]
        public string Hello()
        {
            return "Index?";
        }
    }
}