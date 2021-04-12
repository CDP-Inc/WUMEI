using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.IO;
using System.Linq;
using System.Reflection;

namespace WUMEI
{
    /// <summary>
    /// Class that configures services and the application's request pipeline.
    /// </summary>
    /// <remarks>https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup</remarks>
    public class Startup
    {
        /// <summary>
        /// Gets the key/value application configuration properties.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="configuration">A set of key/value application configuration properties.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddVersionedApiExplorer(
               options =>
               {
                   options.GroupNameFormat = "VVV";
                   options.SubstituteApiVersionInUrl = true;
               }
            );
            services.AddApiVersioning(
                options =>
                {
                    options.ReportApiVersions = true;
                    options.UseApiBehavior = false;
                }
            );
            services.AddSwaggerGen(
                options =>
                {
                    var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
                    }
                    options.OperationFilter<SwaggerDefaultValues>();
                    options.IncludeXmlComments(XmlCommentsFilePath);
                    options.CustomSchemaIds(t => t.FullName);
                }
            );
            services.AddSwaggerGenNewtonsoftSupport();
        }

        /// <summary>
        /// Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Defines a class that provides the mechanisms to configure an application's request pipeline.</param>
        /// <param name="env">Provides information about the web hosting environment an application is running in.</param>
        /// <param name="provider">Provider for API version description.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(
                options =>
                {
                    foreach (var description in provider.ApiVersionDescriptions
                        .OrderByDescending(x => x.ApiVersion.MajorVersion.GetValueOrDefault()))
                    {
                        options.SwaggerEndpoint($"/WUMEISample/swagger/{description.GroupName}/swagger.json",
                            description.GroupName.ToUpperInvariant());
                        options.SupportedSubmitMethods(new SubmitMethod[] { });
                    }
                }
            );
        }

        /// <summary>
        ///
        /// </summary>
        static string XmlCommentsFilePath
        {
            get
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = $"WIC Universal MIS-EBT Interface API {description.ApiVersion}",
                Description = $"API for the {description.ApiVersion} version of the WUMEI.",
                Version = description.ApiVersion.ToString()
            };
            return info;
        }
    }
}
