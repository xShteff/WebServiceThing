using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model
{
    public class CarList
    {
        private List<Car> list;

        public CarList()
        {
            this.list = new List<Car>();
        }

        public CarList(List<Car> list)
        {
            this.list = list;
        }

        public List<Car> List { get; set; }

    }
}
