using CarService.Model;
using CarService.Service;
using CarWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWebApplication.Controllers
{
    public class CarController : Controller
    {
        private ICarListService _carListService;

        public CarController(ICarListService carList)
        {
            _carListService = carList;
        }
        public IActionResult Index()
        {
            CarList cars = _carListService.getCars();
            return View(new CarViewModel {
                List = cars
            });
        }
    }
}
