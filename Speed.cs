class Program
    {
        static void Main(string[] args)
        {
            float distance;
            float hours;
            float minutes;
            float seconds;
            float metresPerSecond;
            float kilometersPerHour;
            float milesPerHour;
            float totalTimeSeconds;


            Console.WriteLine("Please enter distance in metres: ");
            distance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter hours : ");
            hours = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter minutes ; ");
            minutes = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter seconds : ");
            seconds = Convert.ToSingle(Console.ReadLine());

            totalTimeSeconds = (hours*3600) + (minutes*60) + seconds;

            metresPerSecond = distance/totalTimeSeconds;
            Console.WriteLine("Speed is {0} m/s.", metresPerSecond);

            kilometersPerHour = (distance/1000.0f)/ (totalTimeSeconds/3600.0f);
            
            Console.WriteLine("Speed is {0} kph.", kilometersPerHour);

            milesPerHour = kilometersPerHour / 1.60934f;
            Console.WriteLine("Speed is {0} mph. ", milesPerHour);

            Console.ReadLine();

        }
    }