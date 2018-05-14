using CarService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Service
{
    public interface ICarListService
    {
        CarList getCars();

        Car getCar(int id);
    }
}
