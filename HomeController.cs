using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers{
    public class HomeController : Controller
    {
        public string Index(){
            return "Hello Store App";
        }
    }
}