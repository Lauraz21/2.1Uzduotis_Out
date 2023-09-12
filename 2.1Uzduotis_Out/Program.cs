namespace _2._1Uzduotis_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                bool convert = int.TryParse(Console.ReadLine(), out int userInput);

                if (userInput > 100 || !convert)
                {
                    break;
                }
            }
        }

    }
}