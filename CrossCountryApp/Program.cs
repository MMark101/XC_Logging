// Program.cs
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using StravaSharp;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();

        // Instantiate and use your custom class
        var myService = new MyService();
        myService.DoSomething();
        //var auth = new StravaController(new StravaAuthService());
        //var client = new Client(auth);
        // now you can use the Client
        //var activities = await client.Activities.GetAthleteActivities();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
