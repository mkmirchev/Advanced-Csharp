namespace Restaurant
{
    public class Dessert : Food
    {
        public double Callories { get; set; }
        public Dessert(string name, decimal price, double grams, double callories) : base(name, price, grams)
        {
            this.Callories = callories;
        }
    }
}
