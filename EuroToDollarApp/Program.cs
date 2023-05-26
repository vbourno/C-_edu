namespace EuroToDollarApp
{
    /// <summary>
    /// Reads an amount of Euros and calculates
    /// the correspondent amount of US Dollars
    /// using a fixed price of 116 US cents per Euro.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FIXEDPRICE = 116;
            float dollars;
            float euros;

            Console.WriteLine("Please provide the amount of euros to be converted: ");
            euros = float.Parse(Console.ReadLine()!);
            dollars = FIXEDPRICE * (euros / 100);
            Console.WriteLine("{0} euros are equal to {1} US dollars.", euros, dollars);
        }
    }
}