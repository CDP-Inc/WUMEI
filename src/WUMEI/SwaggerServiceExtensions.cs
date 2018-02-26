using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;

namespace WUMEI
{
    /// <summary>
    /// Helper class to centralize Swagger startup setup.
    /// </summary>
    public static class SwaggerServiceExtensions
    {
        /// <summary>
        /// Adds Swagger documentation configuration to service pipeline.
        /// </summary>
        /// <param name="services">Service collection to add Swagger to.</param>
        /// <returns>Returns the updated service collection.</returns>
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2018", new Info
                {
                    Title = "WIC Universal MIS-EBT Interface Technical Specification",
                    Description = "Initial draft of API technical specification for the latest version of the WUMEI.",
                    Version = "v2018"
                });
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "WUMEI.xml"));
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT authorization header using the bearer scheme (for example: \"Authorization: Bearer {token}\").",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
            });
            return services;
        }

        /// <summary>
        /// Adds Swagger documentation configuration to the application builder pipeline.
        /// </summary>
        /// <param name="app">Applicaiton builder to add Swagger to.</param>
        /// <returns>Returns the updated application builder.</returns>
        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/WUMEI/swagger/v2018/swagger.json", "WUMEI v2018");
                c.SupportedSubmitMethods(new string[] { });
            });
            return app;
        }
    }
}
