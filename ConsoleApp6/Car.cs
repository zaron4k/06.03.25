using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car
    {
        private string make;
        private string model;
        private double year;

        public string Make
        {
            get { return make; }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }
        public double Year
        {
            get { return year; }
            set
            {
                if (value < 20)
                    year = 2000;
                else if (value > 120)
                    year = 2000;
                else year = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Car()
        { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="brond"></param>
        public Car(string make, string model, double year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public override string ToString()
        {
            return $"Марка: {Make}\nМодель: {Model}\nГод: {Year} км/ч";
        }
    }
}
