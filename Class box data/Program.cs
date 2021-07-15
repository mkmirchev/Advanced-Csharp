using System;

namespace Class_box_data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double l = double.Parse(Console.ReadLine());
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Box b = new Box(l, w, h);
                b.BoxSurfaceArea();
                b.BoxLiteralArea();
                b.BoxVolume();
            }
            catch (Exception ae)
            {
                
                Console.WriteLine(ae.Message);
                //throw;
            }         
        }
    }

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length 
        {
            get
            {
                return this.length;
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negarive.");
                }
                length = value;
            } 
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }
        public Box(double length,double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public void BoxSurfaceArea()
        {
            double surface = 2 *( length*height + length*width + height*width);
            Console.WriteLine($"Surface Area = {surface:F2}");
        }
        public void BoxLiteralArea()
        {
            double surface = 2 * (length * height + height * width);
            Console.WriteLine($"Lateral Area = {surface:F2}");
        }
        public void BoxVolume()
        {
            double volume = (length * height * width);
            Console.WriteLine($"Volume = {volume:F2}");
        }
    }

}
