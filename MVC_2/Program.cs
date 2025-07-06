using MVC_2.Services;
using MVC_2.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace MVC_2
{
	//
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();

			//builder.Services.AddSingleton<IGreetingService, GreetingService>();

			var app = builder.Build();

			app.UseStaticFiles();

			//default и другие
			app.MapControllerRoute("default", "{controller=Calculator}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
