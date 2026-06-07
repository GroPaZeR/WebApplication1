using Microsoft.AspNetCore.Identity;
using ClassLibrary;
using System.Text.Json;

namespace WebApplication1
{
    public class Program
    {
        static public readonly string userDataPath = @"UserData.Json";
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.Run();


            /*
            string[] data = File.ReadAllLines(userDataPath);

            User[] users = new User[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                users[i] = new User();
                users[i] = JsonSerializer.Deserialize<User>(data[i]);
            }

            app.Run(async (context) =>
            {
                for (int i = 0; i < users.Length; i++)
                {
                    await context.Response.WriteAsync($"<h1>User Info: {i}<h1>");
                    await context.Response.WriteAsync($"<h3>name: {users[i].Name}</h3>");
                    await context.Response.WriteAsync($"<h3>us: {users[i].Username}</h3>");
                    await context.Response.WriteAsync($"<h3>id: {users[i].Id}</h3>");
                }
            });
            */
            app.Run();
        }
    }
}