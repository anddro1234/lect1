namespace lect5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* davaleba1

             int[] ar1 = [ 1, 2, 3, ];
             int[] ar2 = [ 4, 5, 6, ];

             int[] ar3 = [..ar1, ..ar2];

             Console.WriteLine(string.Join(", ", ar3));
            */
            int[] array = [3, 5, -4, 8, 11, 1, -1, 6];
            Console.WriteLine("Enter target sum:");

            if (int.TryParse(Console.ReadLine(), out int targetSum))
            {
                int[][] resultArray = [];

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] + array[j] == targetSum)
                        {
                            resultArray = [.. resultArray, [array[i], array[j]]];
                        }
                    }
                }

                Console.Write("resultArray = [ ");
                foreach (var pair in resultArray)
                {
                    Console.Write($"[{pair[0]}, {pair[1]}] ");
                }
                Console.WriteLine("]");
            }

        }
    }
}
