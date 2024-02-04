namespace Agenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Suporte aos Controllers
            builder.Services.AddControllers();

            // Suporte ao banco de dados
            builder.Services.AddDbContext<AppDbContext>();

            var app = builder.Build();

            // Usar a Rota (Map) dos Controllers
            app.MapControllers();

            app.Run();
        }
    }
}
