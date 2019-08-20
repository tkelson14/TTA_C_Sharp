using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cake = { "butter", "eggs", "flour", "sugar", "clam" };

            Console.WriteLine("Add a special ingredient for a cake: ");
            string word = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < cake.Length; i++)
            {
                cake[i] = cake[i].Replace("clam", word);
            }

            foreach (string x in cake)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();

            int goat = 6;
            int processed = 0;
            while (goat == 6)
            {
                Console.WriteLine("Ah, ah, ah, you didn't say the magic word...");
                if (++processed == 25) break; //the fix
            }

            while (goat < 12)
            {
                Console.Write("Ah, ");
                goat++;
            }

            while (goat <= 15)
            {
                Console.WriteLine("You didn't say the magic word.");
                goat++;
            }


            List<string> color = new List<string>() { "green", "red", "blue", "black", "white", "purple", "orange", "yellow", "brown", "grey" };
            Console.WriteLine("Ok, fine, name a color: ");

            string userColor = Convert.ToString(Console.ReadLine());

            foreach (string index in color)
            {
                if (index == userColor)
                {
                    Console.WriteLine("The index of that color in my String is: " + color.IndexOf(index));
                }
            }

            if (!color.Contains(userColor))
            {
                Console.WriteLine("That color is not in the list.");
            }

            List<string> model = new List<string>() { "tacoma", "camry", "fj cruiser", "4runner", "highlander", "corolla", "tacoma", "camry", "4runner", "tundra" };
            Console.WriteLine("Now name a model of Toyota: ");
            string carmodel = Convert.ToString(Console.ReadLine());
            int dupl = 0;
            int indexer = 0;
            foreach (string index in model)
            {
                if (index == carmodel)
                {
                    Console.WriteLine("The index of that model in my String is: " + indexer);
                    indexer++;
                    dupl++;
                }
                else if (!model.Contains(carmodel))
                {
                    Console.WriteLine("That model does not exist in my world.");
                }
                else
                {
                    indexer++;
                }
            }

            if (dupl > 0)
            {
                Console.WriteLine("That item is in the list " + dupl + " times.");
            }







            Console.ReadLine();
        }
    }
}
