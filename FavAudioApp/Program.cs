using FavAudioApp.DAO;
using FavAudioApp.Service;

namespace FavAudioApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IRadioDAO, RadioDAOImpl>();
            builder.Services.AddScoped<IRadioService, RadioServiceImpl>();
            builder.Services.AddScoped<ISongDAO, SongDAOImpl>();
            builder.Services.AddScoped<ISongService, SongServiceImpl>();
            builder.Services.AddScoped<IPlaylistDAO, PlaylistDAOImpl>();
            builder.Services.AddScoped<IPlaylistService, PlaylistServiceImpl>();
            builder.Services.AddScoped<IPodcastDAO, PocdastDAOImpl>();
            builder.Services.AddScoped<IPodcastService, PodcastServiceImpl>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}