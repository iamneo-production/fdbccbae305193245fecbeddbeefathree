﻿using System;
using System.Linq;
using KathakBookingSystem.Data;
using KathakBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KathakBookingSystem.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult AvailableClasses()
        { ViewBag.Name="Sajeed";
            //Write Functionality to display AvailableClasses return view
            return View();
        }
    }
}
