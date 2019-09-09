// Name: ASPNET lab04
// Author: James Smelser
// Date: August 24, 2019
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = 
                {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
                };
            Func<Product, bool> nameFilter = delegate (Product prod) {return prod?.Name?[0] == 'S';};
            decimal priceFilterTotal = productArray
            .Filter(FilterByPrice)
            .TotalPrices();
            decimal nameFilterTotal = productArray
            .Filter(nameFilter)
            .TotalPrices();
            return View("Index", new string[] {$"Price Total: {priceFilterTotal:C2}",$"Name Total: {nameFilterTotal:C2}" });

            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
            //return View("Index", new string[] { $"Array Total: {arrayTotal:C2}, Name Total: {nameFilterTotal:C2}" });

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();
            //return View("Index", new string[] {$"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });

            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{ 
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            //};
            //return View("Index", products.Keys);

            //List<string> results = new List<string>();
            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    string category = p?.Category;
            //    decimal? price = p?.Price ?? 0M;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    bool? instock = p?.InStock ?? false;
            //    //results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            //    results.Add($"Name: {name}, Category: {category}, Price: {price}, Related: {relatedName}, InStock: {instock}");

            //}
            //return View(results);
            //}
        }
    }
}
