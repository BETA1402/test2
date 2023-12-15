using Microsoft.AspNetCore.Mvc;

namespace test2.Controllers
{
    public class SayhiController : Controller
    {
        public string toarmin(string name)
        {
            return $"hi {name}";
        }
    }
}
