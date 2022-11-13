namespace AdminPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=analytics}/{action=index}");
            app.Run();
        }
    }
}