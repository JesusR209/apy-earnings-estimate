namespace apy_earnings_estimate;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How much is currently in your savings account?");

        int savings = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is your current interest rate? Enter a whole number(example: 4)");

        int apy = Convert.ToInt32(Console.ReadLine());

        double earnings = savings * (apy * 0.01);
        
        double daily = earnings/365;
        string formattedDaily = daily.ToString("F2");
        double monthly = daily * 30;
        string formattedMonthly = monthly.ToString("F2");

        Console.WriteLine($"With a APY of {apy}%, your annual earnings on ${savings} should be around ${earnings} by the end of the year!");
        Console.WriteLine($"Thats ${formattedDaily} a day, or ${formattedMonthly} per month!");
    }
}
