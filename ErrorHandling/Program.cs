namespace ErrorHandling
{
    internal class Program
    {
        static void Main()
        {
            // case 1
            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre");
            }
            else if (number < 3)
            {
                Console.WriteLine("Talet är mindre än tre");
            }

            // case 2
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            // case 3
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            // case 4
            int k = 1;
            while (k <= 5)
            {
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("j " + j);
                }
                Console.WriteLine();
                k++;
            }

            // case 5
            int m = 1;

            switch (m)
            {
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            // case 6
            int n = 10;

            if (n != 5)
            {
                Console.WriteLine("i är 5");
            }
        }
    }
}
