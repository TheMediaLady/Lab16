using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            string coList = ("countries.txt");
            if (File.Exists(coList))
            {
                using (StreamReader readList = File.OpenText(coList))
                {
                    string noBlanks = "";
                    while ((noBlanks = readList.ReadLine()) != null)
                    {
                        Console.WriteLine(noBlanks);
                    }
                    readList.Close();
                }

                Console.WriteLine("Welcome to the Countries Maintence Application!\n");
                do
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1 - See the list of countries");
                    Console.WriteLine("2 - Add a country");
                    Console.WriteLine("3 - Exit");
                    Console.ReadLine();

                    Console.WriteLine("Enter menu number:  ");
                    int number = int.Parse(Console.ReadLine());


                    if (number == 1)
                    {
                        Console.WriteLine(coList);
                    }

                    if (number == 2)
                    {
                        using (StreamWriter addCountry = File.CreateText(coList)) ;
                    }

                    Console.WriteLine("Please enter your country");
                    string addName = Console.ReadLine();
                    addName.WriteLine("Africa");
                    addName.WriteLine("Asia");

                } while (number != 3);
              

                if (number == 3)
                {
                    Console.WriteLine("Goodbye!");
                }


                
                
            }
        }
    }    
}

