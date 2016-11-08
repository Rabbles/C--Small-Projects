class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int temp;

            Console.WriteLine("\nPlease enter Integrer 1 : ");

            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter Integer 2 : ");

            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("Integer 1 : " + number1);
            Console.WriteLine("Integer 2 : " + number2 );
            Console.Read();
        }
    }