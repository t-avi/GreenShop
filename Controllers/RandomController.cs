using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class RandomController : Controller
    {
        //пример DI
        private readonly IMyDependency myDependency; //используем service type а не implementation type
        public RandomController(IMyDependency myClass)
        {
           this.myDependency = myClass;
        }
        public string Index() => myDependency.Value.ToString();
    }
}
