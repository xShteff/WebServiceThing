using CarService.Service;
using System;

namespace CarService
{
    class Program
    {
        static void Main(string[] args)
        {
            CarListService carServ = new CarListService();
            Console.WriteLine(carServ.getCar(0).toString());
            Console.ReadKey();
        }
    }
}
