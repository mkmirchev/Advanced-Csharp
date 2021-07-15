using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persons = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] products = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();
            string wrongData = null;
            List<Person> prsns = new List<Person>();
            foreach (var prsn in persons)
            {
                string name = prsn.Split('=')[0];
                decimal money = decimal.Parse(prsn.Split('=')[1]);
                try
                {
                    Person p = new Person(name, money);
                    prsns.Add(p);
                }
                catch (Exception ae)
                {
                    wrongData = ae.Message;
                    //throw;
                }
             
            }
            List<Product> prd = new List<Product>();
            foreach (var pr in products)
            {
                string name = pr.Split('=')[0];
                decimal price = decimal.Parse(pr.Split('=')[1]);
                try
                {
                    Product p = new Product(name, price);
                    prd.Add(p);
                }
                catch (Exception ae)
                {
                    wrongData = ae.Message;
                    //throw;
                }
               
            }
            string[] input = new string[2];
            while (input[0] != "END")
            {
                input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    if (wrongData != null)
                    {
                        Console.WriteLine(wrongData);
                    }
                    else
                    {
                        foreach (Person item in prsns.Where(x => x.Bag.Count == 0))
                        {
                            Console.WriteLine($"{item.Name} - Nothing bought");
                        }
                    }
                    
                    break;                   
                }
                prsns.FirstOrDefault(x => x.Name == input[0]).Affort(prd.FirstOrDefault(s => s.Name == input[1]));               
            }
        }
    }
}
