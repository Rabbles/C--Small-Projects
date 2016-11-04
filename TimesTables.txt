class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int output;

            Console.WriteLine("Enter multiplicand : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter multiplier : ");
            num2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= num2; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num1, i, num1 * i );
            }

            Console.ReadLine();
        }
    }