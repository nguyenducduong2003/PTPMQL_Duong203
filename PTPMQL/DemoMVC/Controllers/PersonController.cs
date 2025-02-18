using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Căn cước công dân: " + ps.PersonId + " - Ơn giời: " + ps.FullName + " - Đây rồi: " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
    }
}