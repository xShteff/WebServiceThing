using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model
{
    public class Car
    {
        public string name { get; set; }
        public string model { get; set; }

        public string toString()
        {
            return $"Name: {this.name}; Model: {this.model}";
        }
    }
}
