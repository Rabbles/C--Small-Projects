class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            int output;

            Console.WriteLine("\nPlease enter first multplier : ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter second multiplier : ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter third multiplier : ");
            number3 = int.Parse(Console.ReadLine());

            output = number1*number2*number3;

            //Console.WriteLine("" + number1 + " x " + number2 + 
            //                   " x " + number3 + " = " + output );

            //Alternative output syntax
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                              number1, number2, number3, output);

            Console.ReadLine();
        }
    }