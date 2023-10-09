namespace Agenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers(); // Suporte aos Controllers
            builder.Services.AddDbContext<AppDbContext>(); // Suporte ao banco de dados

            var app = builder.Build();
            app.MapControllers(); // Usar a Rota (Map) dos Controllers

            app.Run();
        }
    }
}
