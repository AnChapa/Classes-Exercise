namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car yourCar = new Car();
            myCar.Make = "Subaru";
            myCar.Model = "Impreza";
            myCar.Year = 2015;
            Console.WriteLine("What manufacturer made your car?");
            yourCar.Make = Console.ReadLine(); 
            Console.WriteLine("What model is your car?");
            yourCar.Model = Console.ReadLine();
            Console.WriteLine("What year was it made?");
            yourCar.Year = int.Parse(Console.ReadLine());

            Console.WriteLine($"You drive a {yourCar.Year} {yourCar.Make} {yourCar.Model}?");
            if (myCar.Make == yourCar.Make && myCar.Model == yourCar.Model && myCar.Year == yourCar.Year)
            {
                Console.WriteLine("Hey! That's my car!");
            }
            else
            {
                Console.WriteLine($"That's cool! I drive a {myCar.Year} {myCar.Make} {myCar.Model}.");
            }
        }
    }
}
