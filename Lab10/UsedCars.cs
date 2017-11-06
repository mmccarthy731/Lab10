namespace Lab10
{
    class UsedCars : Cars
    {
        private double miles;

        public double Miles
        {
            get { return miles; }
            set { miles = value; }
        }

        // Constructor for UsedCars, inherits from Cars
        public UsedCars(string make, string model, int year, double price, double miles)
            : base(make, model, year, price)
        {
            this.miles = miles;
        }

        // Override of the ToString method for UsedCars
        public override string ToString()
        {
            return base.ToString() + $"{"(USED)", 10}{miles, 10:N0}";
        }
    }
}
