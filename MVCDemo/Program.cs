using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();

            //app.Use(async (context, next) =>
            //{
            //    Endpoint endpoint = context.GetEndpoint();
            //    if (endpoint is null)
            //        await context.Response.WriteAsync("Your Requested Page Not Found ");

            //    await next();
            //});

            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Home page!");
            //    });

            //    endpoints.MapGet("/Products/{id:int?}", async context => // id? hena ? di option parameter y3ni mmkn ab3to w mmkn la
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"You Request Product With Id => {id}");
            //        }
            //        else await context.Response.WriteAsync("You are at Products page");

            //    });

            //    endpoints.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]); 
            //        string author = context.Request.RouteValues["author"].ToString();

            //        await context.Response.WriteAsync($"You Request Book With Id => {id} and Author => {author}");
            //    });
            //});
            #endregion

            app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home}/{action=Index}",
               defaults: new {Controller = "Home", action = "Index"}
            );

            //app.Run(async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("Your Requested Page Not Found ");
            //}); 

            app.Run();
        }
    }
}

