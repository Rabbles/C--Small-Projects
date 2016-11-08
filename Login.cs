class Program
    {
        static void Main(string[] args)
        {
            string userID = "TestID";
            string password = "RobustPassword";
            string inputUserId;
            string userInputPass;
            int failCounter = 0;

            do
            {
                Console.WriteLine("Please enter your Username : ");
                inputUserId = Console.ReadLine();

                Console.WriteLine("Please enter your Password : ");
                userInputPass = Console.ReadLine();

                failCounter++;
            } 
            
            while (userID != inputUserId
                    && password != userInputPass
                    && failCounter != 3 );

            if (failCounter == 3)
            {
                Console.WriteLine("Access Denied :-( ");
            }
            else
            {
                Console.WriteLine("Permission Granted!");
            }

            Console.ReadLine();
        }
    }