using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index(){
            var product =new Product{Name="Nike Air Max 270 React Cactus Trails ",Price=6000,Description="Used"};
            ViewData["Product"]=product;
            ViewData["Category"]="Sneakers";
            return View();
        } 
        //localhost:5000/product/list
        public IActionResult List(){
            var products= new List<Product>(){
                new Product{Name="AJ 1 Retro High 85' Varsity Red",Price=3000,Description="Brand New",isApproved=true, Image="https://stockx.imgix.net/Air-Jordan-1-Retro-High-85-Varsity-Red-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1581534052"},
                new Product{Name="AJ 1 Retro High Court Purple ",Price=2780,Description="Used",isApproved=true, Image="https://stockx.imgix.net/Air-Jordan-1-Retro-High-Court-Purple-White-GS.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1586615077"},
                new Product{Name="AJ 1 Retro High Travis Scott",Price=3600,Description="Brand New",isApproved=true, Image="https://stockx.imgix.net/Air-Jordan-1-Retro-High-Travis-Scott-Product.jpg?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&dpr=2&trim=color&updated_at=1550180948"},
                new Product{Name="AJ 1 Retro High Bloodline ",Price=1970,Description="Brand New", Image="https://stockx-360.imgix.net//Air-Jordan-1-Retro-High-Bloodline/Images/Air-Jordan-1-Retro-High-Bloodline/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1573759145"}
            };

            var category= new Category{Name="Sneakers",Description="Sneakers Category"};
            
            var productViewModel = new ProductViewModel(){
                Category=category,
                Products=products
            };

            return View(productViewModel);
        } 
        //localhost:5000/product/details
        public IActionResult Details(int id){
            var p = new Product();
            p.Name="AJ 1 High OG Chicago 2003";
            p.Price=7600;
            p.Description="Brand New";

            return View(p);
        }
    }
}