using System;
using System.Collections.Generic;
using System.Linq;

namespace ListAnalog
{


    //dictionary

    class Countries
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public decimal Population { get; set; }
    }

    class KeysType<T>
    {
        public T Keys { get; set; }
    }

    class Program
    {
        public static Countries foundedKey { get; private set; }
        static void Main(string[] args)
        {
            Dictionary<int, Countries> countries = new Dictionary<int, Countries>();

            // add elements
            countries.Add(1, new Countries { Name = "German", Capital = "Berlin", Population = 83783942 });
            countries.Add(2, new Countries { Name = "Georgia", Capital = "Tbilisi", Population = 3981167 });
            countries.Add(3, new Countries { Name = "UK", Capital = "London", Population = 53981167 });
            countries.Add(4, new Countries { Name = "Italy", Capital = "Rome", Population = 33981167 });

            //find by index
            if (countries.ContainsKey(1))
            {
                foundedKey = countries[1];
                Console.WriteLine(foundedKey.Name);
            }
            else
            {
                Console.WriteLine("it is baaad!");
            }

            //delete elements
            countries.Remove(1);
            Console.WriteLine(countries);

            foreach (var item in countries)
            {
                Console.WriteLine($"keys: {item.Key} and values: {item.Value.Name}");
            }

            //count keys
            int count1 = countries.Count();
            Console.WriteLine(count1);

        }
    }

}
