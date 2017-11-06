using System.Collections;

namespace Lab10
{
    class Cars
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Cars(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public Cars()
        {

        }

        // Override of the ToString method for Cars
        public override string ToString()
        {
            return $"{make,-15}{model,-20}{year,-5}{price,15:C}";
        }
    }
}
