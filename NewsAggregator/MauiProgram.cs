using Microsoft.Extensions.Logging;
using NewsAggregator.Interfaces;
using NewsAggregator.Services;


namespace NewsAggregator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder
               .UseMauiApp<App>()
               .ConfigureMauiHandlers(handlers =>
               {
#if ANDROID
                   handlers.AddHandler(typeof(Shell), typeof(MyShellRenderer));
#endif
               });
            builder.Services.AddSingleton<IFirebaseAuthentication, FirebaseAuthentication>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
