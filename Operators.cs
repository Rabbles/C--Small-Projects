class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Input the first number ; ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);

            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);

            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);

            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);

            Console.ReadLine();

        }
    }