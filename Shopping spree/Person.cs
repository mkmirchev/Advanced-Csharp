using System;
using System.Collections.Generic;

namespace Shopping_spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = bag;
            bag = new List<string>();
        }
        public string Name
        { 
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money 
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }   
        public List<string> Bag 
        { 
            get
            {
                return this.bag;
            }
            set
            {
                
            }
        }

        public void Affort(Product p)
        {
            if (this.money - p.Price < 0)
            {
                Console.WriteLine($"{this.name} can't afford {p.Name}");
            }
            this.bag.Add(p.Name);
            this.money -= p.Price;

        }
    }
}
