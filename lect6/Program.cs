using System.Linq.Expressions;
using System.Net.Security;

namespace lect6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   davaleba 1
               int[][] pointsjugged = [
                   [1,2,7,8,10],
                   [7,8,7,8,10],
                   [7,5,4,8,10],
                   [9,8,9,10,8],
                   ];
               foreach (var line in pointsjugged)
               {
                   float sum = 0;
                   foreach (var item in line)
                   {
                       sum += item;
                   }
                   Console.WriteLine(sum / line.Length);
               }
               */
            /* davaleba 2
            string[] paskodes = new string[10];
            Random random = new Random();

            for (int i = 0; i < paskodes.Length; i++) {

                paskodes[i] = random.Next(10, 25).ToString();

            } 
            string userInput = Console.ReadLine();

            

            foreach (var item in paskodes){
                     Console.WriteLine(item);
                if (userInput == item)
                {
                    Console.WriteLine("your code is corect");  
                }
                else
                {
                    Console.WriteLine("your kode is incorect");
                }
            }
            
            */
            /* davaleba 3
            int[] numbers = [1,-9, 3, -4, 5, -2];

            int min = numbers[0];
            int max = numbers[0];

            foreach (var item in numbers)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
                Console.WriteLine("max num " + max);
                Console.WriteLine("min num " + min);
            }*/
            /* davaleba 4

            string[] stringarry = {"text", "hii","arry","hello" };

            foreach (var item in stringarry)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("---");
            }

            */
            /* davaleba 5
            string[] gmail = ["andria@gmail.com" , "vigaca@gmail.com", "ragacagmail.com"];

            foreach (var item in gmail)
            {
                if (item.Contains("@"))
                {
                    Console.WriteLine("valid gmail"); 
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            */
        }
    }
}
