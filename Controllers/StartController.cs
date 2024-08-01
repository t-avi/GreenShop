using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Hello()
        {
            var time = TimeOnly.FromDateTime(DateTime.Now);

            var hello = "henlo frend";

            /*Ночь - 0:00 до 05:59

            Утро - 06:00 до 11:59

            День - 12:00 до 17:59

            Вечер - 18:00 до 23:59*/

            if (time >= new TimeOnly(0,0) && time <= new TimeOnly(5, 59)) {
                hello = "Доброй ночи!";
            }
            else if (time >= new TimeOnly(6, 0) && time <= new TimeOnly(11, 59))
            {
                hello = "Доброго утра!";
            }
            else if (time >= new TimeOnly(12, 0) && time <= new TimeOnly(17, 59))
            {
                hello = "Добрый день!";
            }
            else if (time >= new TimeOnly(18, 0) && time <= new TimeOnly(23, 59))
            {
                hello = "Добрый вечер!";
            }

            return hello;
        }
    }
}
