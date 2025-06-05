using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GreenShop.Views.Shared.Component.CompareViewComponent
{
    public class CompareViewComponent : ViewComponent
    {
        private readonly ICompare comparedProducts;
        public CompareViewComponent(ICompare comparedProducts)
        {
            this.comparedProducts = comparedProducts;
        }
        public IViewComponentResult Invoke()
        {
            var amount = comparedProducts.GetComparedProducts().Count;
            var comparedCount = amount == 0 ? "" : amount.ToString();

            return View("Compare", comparedCount);
        }
    }
}
