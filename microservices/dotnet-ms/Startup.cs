namespace dotnetms
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Set the path base using an environment variable. SERVER_SERVLET_CONTEXT_PATH is provided by Entando and used in the auto-wiring of the ready/live checks
            var pathBase = Environment.GetEnvironmentVariable("SERVER_SERVLET_CONTEXT_PATH") ?? string.Empty;            
            if (!string.IsNullOrEmpty(pathBase))
            {
                app.UsePathBase(pathBase);
            }

            // Enable to only include Swagger in Dev.
            // if (app.Environment.IsDevelopment())
            // {
                app.UseSwagger();
                app.UseSwaggerUI();
            // }

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
