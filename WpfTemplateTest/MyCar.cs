using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTemplateTest
{
    class MyCar
    {
        public string Year { get; set; }

        public string Price { get; set; }

        public MyCar(string year, string price)
        {
            Year = year;
            Price = price;
        }
    }
}
