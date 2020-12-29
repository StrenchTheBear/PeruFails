using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeruFails.Models;
using PeruFails.Data;

namespace PeruFails.Controllers
{
    public class RegistrarseController : Controller
    {
        private readonly ILogger<RegistrarseController> _logger;

        public RegistrarseController(ILogger<RegistrarseController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}