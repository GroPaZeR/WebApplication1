using Microsoft.AspNetCore.Identity;

namespace WebApplication1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();

            app.Run(async (context) =>
            {

                await context.Response.WriteAsync(File.ReadAllText(@"S:\Coding\C# Projects\WebApplication1\WebApplication1\wwwroot\Index.html"));

            });

            app.Run();
        }
    }
}