using Adam.albadre.omnisharp.Services.CharacterServices;

namespace Adam.albadre.omnisharp
{
    public class Startup
    {

        public IConfiguration? Configuration { get; }
        public void ConfigurServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "dotnet_rpg", Version = "v1 "});

            });
            services.AddScoped<ICharacterService, CharacterService>();
            
        }
    }
}