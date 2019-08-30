using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                try
                {
                    Console.WriteLine("Please enter your age.");
                    int age = Convert.ToInt32(Console.ReadLine());
                    DateTime currentTime = DateTime.Now;
                    int birthYear = currentTime.Year - age;
                    Console.WriteLine("You were born in {0}.", birthYear);
                    Console.ReadLine();
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter digits only");
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("An error has occured. Contact system admin.");
                    return;
                }
                finally
                {
                    Console.ReadLine();
                }
            }

        }   
           
    }
}
