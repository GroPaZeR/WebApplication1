using Microsoft.AspNetCore.Identity;
using ClassLibrary;
using System.Text.Json;
using System.Text;

namespace WebApplication1
{
    public class Program
    {
        static public readonly string newsDataPath = @"NewsDatabase.Json";
        static public readonly string userDataPath = @"UserData.Json";
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapRazorPages();


            News news = new News();

            news.readArticles();

            /*
            string[] data = File.ReadAllLines(userDataPath);

            User[] users = new User[data.Length];
            */
            app.Run();
        }
    }
}