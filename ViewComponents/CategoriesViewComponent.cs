using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Views.Shared.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(){
            var categories = new List<Category>()
            {
                new Category{Name="Sneakers",Description="Sneakers Category"},
                new Category{Name="Apparel",Description="Apparel Category"}
                
            };
            return View(categories);
        }
    }
}