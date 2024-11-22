
using Microsoft.AspNetCore.Mvc;

namespace HotelMgmtSystem.Areas.Settings.Controllers;
[Area("Settings")]
public class AppController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
