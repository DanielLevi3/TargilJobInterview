using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        
         static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            List<Street> streets = new List<Street>();
            bool b= true;
            int z = 0;
            int x = 0;
            while (b)
            {
                Console.WriteLine("Please Choose option from the menu \n" +
                    "0.create cities (if there are none this option is diffult)\n" +
                    "1.create street whitin the cities \n" +
                    "2.show the cities and streets\n");
                int press = Convert.ToInt32(Console.ReadLine());
                if (cities.Count == 0|| press == 0)
                {
                    Console.WriteLine("Please enter city name to create one ");
                    string name = Console.ReadLine();
                    z++;
                    City city = CreateCity(name,z);
                    cities.Add(city);
                   
                }
                if (press == 1 && cities.Count > 0)
                {
                    Console.WriteLine("Please enter street name to create one");
                    string s_name = Console.ReadLine();
                    Console.WriteLine("Please enter street city code to create one");
                    int city_code = Convert.ToInt32(Console.ReadLine());
                    x++;
                    Street s = CreateNewStreet(s_name, city_code,x);
                    if (streets.Count > 0)
                    {
                        for (int i = 0; i < streets.Count; i++)
                        {
                            if ((streets[i].CityCode == s.CityCode) && (streets[i].Name == s.Name))
                            {
                                Console.WriteLine("The name already exist please enter name again");
                                s_name = Console.ReadLine();
                                s = CreateNewStreet(s_name, city_code,x);
                                streets.Add(s);
                                break;
                            }
                            else
                            {
                                streets.Add(s);
                                break;
                            }
                        }
                    }
                    else
                        streets.Add(s);
                }
                if (press == 2 )
                {
                    foreach (var c in cities)
                    {
                        Console.WriteLine(c);
                        foreach (var item in streets)
                        {
                            if(item.CityCode ==c.Code)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                }
            }
        }

        public static City CreateCity(string name,int counter)
        {
         
            City c = new City(name,counter);
            return c;
        }
        public static Street CreateNewStreet(string name, int cityCode,int counter)
        {
            Street s = new Street(name, cityCode,counter);
            return s;
        }
    }
}
