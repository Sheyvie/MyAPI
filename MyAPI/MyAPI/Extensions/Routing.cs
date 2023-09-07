namespace MyAPI.Extensions
{
    public class Routing
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
