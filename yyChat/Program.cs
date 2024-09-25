namespace yyChat
{
    public class Program
    {
        public static void Main (string [] args)
        {
            var xBuilder = WebApplication.CreateBuilder (args);

            xBuilder.Services.Configure <RouteOptions> (x => x.LowercaseUrls = true);
            xBuilder.Services.AddRazorPages ();

            var xApp = xBuilder.Build ();

            if (xApp.Environment.IsDevelopment () == false)
            {
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
