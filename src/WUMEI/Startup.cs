using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
//using System.Collections.Generic;
using System.IO;

namespace WUMEI
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2018", new Info
                {
                    Title = "WIC Universal MIS-EBT Interface Technical Specification",
                    Description = "Initial draft of API technical specification for the latest version of the WUMEI.",
                    Version = "v2018"
                });

                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "WUMEI.xml"));

                //c.AddSecurityDefinition("oauth2", new OAuth2Scheme
                //{
                //    Type = "oauth2",
                //    Flow = "implicit",
                //    AuthorizationUrl = "http://petstore.swagger.io/oauth/dialog",
                //    Scopes = new Dictionary<string, string>
                //    {
                //        { "readAccess", "Access read operations" },
                //        { "writeAccess", "Access write operations" }
                //    }
                //});

                //c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/WUMEI/swagger/v2018/swagger.json", "WUMEI v2018");
                //c.ConfigureOAuth2("swagger-ui", "swagger-ui-secret", "swagger-ui-realm", "Swagger UI");
            });
            app.UseMvc();
        }
    }
}
