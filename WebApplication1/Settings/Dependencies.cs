﻿using DataLayer.Repositories;
using Core.Services;

namespace WebApplication1.Settings
{
    public static class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<PlayerService>();
            services.AddScoped<TeamService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<PlayersRepository>();
            services.AddScoped<TeamsRepository>();
        }

    }
}
