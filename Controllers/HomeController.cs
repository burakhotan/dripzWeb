using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController: Controller
    {
        public IActionResult Index(){
            var products= new List<Product>(){
                new Product{Name="AJ 1 Retro High 85' Varsity Red",Price=3000,Description="Brand New",isApproved=true, Image="https://stockx.imgix.net/Air-Jordan-1-Retro-High-85-Varsity-Red-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1581534052"},
                new Product{Name="AJ 1 Retro High Court Purple ",Price=2780,Description="Used",isApproved=true, Image="https://stockx.imgix.net/Air-Jordan-1-Retro-High-Court-Purple-White-GS.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1586615077"},
                new Product{Name="AJ 1 Retro High Travis Scott",Price=3600,Description="Brand New",isApproved=true, Image="https://stockx.imgix.net/Air-Jordan-1-Retro-High-Travis-Scott-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1550180948"},
                new Product{Name="AJ 1 Retro High Bloodline ",Price=1970,Description="Brand New", Image="https://stockx-360.imgix.net//Air-Jordan-1-Retro-High-Bloodline/Images/Air-Jordan-1-Retro-High-Bloodline/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1573759145"}
            };
            var productViewModel = new ProductViewModel(){
                Products=products
            };
            return View(productViewModel);
        }
        public IActionResult About(){
            return View();
        }
    }
}