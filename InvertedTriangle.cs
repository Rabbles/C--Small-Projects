class Program
    {
        static void Main(string[] args)
        {
            int num;
            int width;

            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a triangle width : ");
            width = Convert.ToInt32(Console.ReadLine());


            int height = width;


            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }
               
                Console.WriteLine();
                width--;
            }
            Console.ReadLine();
        }
    }