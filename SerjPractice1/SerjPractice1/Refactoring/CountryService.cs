using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerjPractice1.Models;

namespace SerjPractice1.Refactoring
{
    public class CountryService
    {
        public void StartDraw()
        {
            List<Country> countries = GetCountries();
            Draw(countries);
        }


        private void Choise()
        {
            string choiseRaw = Console.ReadLine();

            if (string.IsNullOrEmpty(choiseRaw))
            {
                Console.WriteLine("You must instroduce either a number from the options above or a country name!");
                Console.Write("Type your choise: ");
                Choise();
            }

            if (int.TryParse(choiseRaw, out int choiseNumber))
            {
                switch (choiseNumber)
                {
                    case 1:
                        Draw(GetCountriesWithStates());
                        break;
                    case 2:
                        Draw(GetCountriesWithRegionsOnly());
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("\nIntroduce numbers between 1 and 5 included!");
                        Console.Write("Type your choise: ");
                        Choise();
                        break;
                }
            }

            if (choiseRaw.ToLower() == "exit")
            {
                Console.Clear();
                Console.WriteLine("Good buy!");
            }
        }

        private void Draw(List<Country> countries)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n");

            foreach (var item in countries)
            {
                Console.Write(string.Format(" Is it state:  {0}", item.IsState ? "YES" : "NO"));
                Console.WriteLine();
                Console.Write(string.Format(" Region name:  {0}", string.IsNullOrEmpty(item.Region) ? "*" : item.Region));
                Console.WriteLine();
                Console.Write(string.Format(" State name:   {0}", string.IsNullOrEmpty(item.State) ? "*" : item.State));
                Console.WriteLine();
                Console.Write(" Country:      " + item.CountryName);
                Console.WriteLine();
                Console.Write("-------------------------------------------------");
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Total records found: " + countries.Count);
            Console.WriteLine("\n\n");

            Console.WriteLine("FILTERING OPTIONS:");
            Console.WriteLine("Type number '1' to get only countries with States.");
            Console.WriteLine("Type number '2' to get only country with regions.");
            Console.WriteLine("Type number '3' to get only USA states.");
            Console.WriteLine("Type number '4' to get only Canada states.");
            Console.WriteLine("Type number '5' to fix the country for Krimea.");
            Console.WriteLine("Type a country name to get info about it.");
            Console.WriteLine("Type a 'exit' to EXIT \n");

            Console.Write("Type your choise: ");
            Choise();
        }

        private List<Country> GetCountriesWithStates()
        {
            return null;
        }
        private List<Country> GetCountriesWithRegionsOnly()
        {
            return null;
        }


        #region Country creation. Static Data
        private List<Country> GetCountries() // Dont' change this method
        {
            return new List<Country>()
            {
                new Country()
                {
                    Region = "Silesia",
                    IsState = false,
                    State = "",
                    CountryName = "Poland"
                },

                new Country()
                {
                    Region = "",
                    IsState = true,
                    State = "New York",
                    CountryName = "USA"
                },

                new Country()
                {
                    Region = "",
                    IsState = true,
                    State = "Florida",
                    CountryName = "USA"
                },

                new Country()
                {
                    Region = "Siberia",
                    IsState = false,
                    State = "",
                    CountryName = "Russia"
                },

                new Country()
                {
                    Region = "Gagausia",
                    IsState = false,
                    State = "",
                    CountryName = "Moldova"
                },

                new Country()
                {
                    Region = "Krimea",
                    IsState = false,
                    State = "",
                    CountryName = "Russia" // change to Ukraine
                },

                new Country()
                {
                    Region = "Tibet",
                    IsState = false,
                    State = "",
                    CountryName = "China"
                },

                new Country()
                {
                    Region = "",
                    IsState = true,
                    State = "Massachusetts",
                    CountryName = "USA"
                },

                new Country()
                {
                    Region = "",
                    IsState = true,
                    State = "Ontario",
                    CountryName = "Canada"
                },

                new Country()
                {
                    Region = "Telangana",
                    IsState = false,
                    State = "",
                    CountryName = "India"
                },

                new Country()
                {
                    Region = "",
                    IsState = true,
                    State = "Alberta",
                    CountryName = "Canada"
                },

                new Country()
                {
                    Region = "Karelia",
                    IsState = false,
                    State = "",
                    CountryName = "Russia"
                },

                new Country()
                {
                    Region = "",
                    IsState = true,
                    State = "New Mexico",
                    CountryName = "USA"
                },

                new Country()
                {
                    Region = "South Saxonia",
                    IsState = false,
                    State = "",
                    CountryName = "Germany"
                },

                new Country()
                {
                    Region = "Firenze",
                    IsState = false,
                    State = "",
                    CountryName = "Italy"
                },

                new Country()
                {
                    Region = "Gujarat",
                    IsState = false,
                    State = "",
                    CountryName = "India"
                }
            };
        }

        #endregion
    }
}
