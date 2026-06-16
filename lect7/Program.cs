using System.Reflection.Metadata.Ecma335;

namespace lect7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  davaleba 1


                Console.WriteLine("ricxvi");
                string nn1 = Console.ReadLine();
                Console.WriteLine("xarisxi");
                string nn2 = Console.ReadLine();
                bool nnuumm1 = int.TryParse(nn1, out int nnnuuummm1);
                bool nnuumm2 = int.TryParse(nn2, out int nnnuuummm2);

                Console.WriteLine("pasuxi");

                int result2 = sum(nnnuuummm1, nnnuuummm2);
                Console.WriteLine(result2); */
            /* davaleba 2

            string number = Console.ReadLine();
            bool nnuumm = int.TryParse(number, out int nnnuuummm);

            if (math(nnnuuummm))
            {
                Console.WriteLine($"martivi ricxvia  {number}");
            }
            else
            {
                Console.WriteLine($"ar aris martivi ricxvi {number}");
            }*/
            /* davaleba 3

            string input = Console.ReadLine();

            if (ispalindrome(input))
            {
                Console.WriteLine("swori palindromia " + input);
            }
            else
            {
                Console.WriteLine("araswori palindromia " + input);
            }*/
            /* davaleba 4

            Console.Write("semoitane mteli ricxvi ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("binaruli canaweri: ");

            binar(input);

            Console.WriteLine();*/
            /* davaleba 5
            Console.Write("Enter base number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine());

            long result = RecursivePower(num, power);

            Console.WriteLine($"{num} to the power of {power} is: {result}"); */
        }
        static int sum(int num1, int num2)
        {

            int result = (int)Math.Pow(num1, num2);
            return result;

        }
        static bool math(int num)
        {
            if (num <= 1) return false;
            if (num == 0) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }



            return true;

        }

        static bool ispalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }
            char first = text[0];
            char last = text[text.Length - 1];

            if (first != last)
            {
                return false;
            }
            string middle = text.Substring(1, text.Length - 2);

            return ispalindrome(middle);
        }
        static void binar(int num)
        {
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num);
                return;
            }
            binar(num / 2);

            Console.WriteLine(num % 2);
        }

        static long RecursivePower(int baseNum, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }

            return baseNum * RecursivePower(baseNum, exp - 1);
        }
    }
}