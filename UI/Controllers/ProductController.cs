﻿using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.ViewModels;

namespace UI.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductManager _productManager;

        public ProductController(ProductManager productManager)
        {
            _productManager = productManager;
        }
        public IActionResult Detail(int? id) 
        {
            DetailProductVM vm = new()
            {
                Product = _productManager.GetProduct(id)
            };  
            return View(vm);
        }
    }
}
