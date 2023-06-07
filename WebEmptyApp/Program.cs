namespace WebEmptyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {  
                webBuilder.UseStartup<Startup>();
            }).Build().Run();

            Console.WriteLine("Thanks for using Coding Factory");
        }
    }
}