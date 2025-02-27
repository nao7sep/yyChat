namespace yyChat
{
    internal sealed class Program
    {
        public static void Main (string [] args)
        {
            var xBuilder = WebApplication.CreateBuilder (args);

            xBuilder.Services.Configure <RouteOptions> (x => x.LowercaseUrls = true);

            // Add services to the container.
            xBuilder.Services.AddRazorPages ();

            var xApp = xBuilder.Build ();

            // Configure the HTTP request pipeline.
            if (xApp.Environment.IsDevelopment () == false)
            {
                // The default HSTS value is 30 days.
                // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                xApp.UseHsts ();

                xApp.UseExceptionHandler ("/Error");
            }

            xApp.UseHttpsRedirection ();
            xApp.UseRouting ();
            xApp.MapRazorPages ();
            xApp.UseAuthorization ();
            xApp.UseStaticFiles ();

            xApp.Run ();
        }
    }
}
