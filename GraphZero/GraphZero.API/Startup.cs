using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;//
using GraphQL.Server;//
using GraphQL.Server.Ui.Playground;//
using GraphQL.Types;//
using GraphZero.API.Data;//
using GraphZero.API.GraphQL;//
using GraphZero.API.Repositories;//
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;//
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GraphZero.API
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly IHostingEnvironment _env;

        public Startup(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;
            _env = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LandDbContext>(options =>
                options.UseSqlServer(_config["ConnectionStrings:GraphZero"]));

            services.AddScoped<LandRepository>();

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<LandSchema>();

            services.AddGraphQL(o => { o.ExposeExceptions = false; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                //.AddUserContextBuilder(httpContext => httpContext.User)//ADDED 4 AUTHORIZATION
                .AddDataLoader();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        public void Configure(IApplicationBuilder app, LandDbContext dbContext)
        {
            app.UseGraphQL<LandSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            dbContext.Seed();
        }
    }
}
