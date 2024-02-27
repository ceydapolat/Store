using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class CategoryController : Controller
{
    public IActionResult Index(){
        return View();
    }
}

