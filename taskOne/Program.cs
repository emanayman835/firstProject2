namespace taskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersmall;
            int numberlarge;
            int priceSmall = 25;
            int pricelarge = 35;
            double taxRate = 0.06;
            Console.WriteLine(" Welcome for carpet cleaning service");
            Console.WriteLine("Number of small carpets:");
            numbersmall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            numberlarge = Convert.ToInt32(Console.ReadLine());
            int coast = (numbersmall * priceSmall) + (numberlarge * pricelarge);
            double tax = coast * taxRate;
            double total = coast + tax;
            Console.WriteLine(total);
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
