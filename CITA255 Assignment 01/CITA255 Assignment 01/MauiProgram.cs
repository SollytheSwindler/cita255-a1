using Microsoft.Extensions.Logging;

namespace CITA255_Assignment_01
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
                    fonts.AddFont("Achafexp.ttf", "Achafexp");
                    fonts.AddFont("Achafita.ttf", "Achafita");
                    fonts.AddFont("Achaflft.ttf", "Achaflft.ttf");
                    fonts.AddFont("Achafont.ttf", "Achafont");
                    fonts.AddFont("Achafout.ttf", "Achafout");
                    fonts.AddFont("Achafsex.ttf", "Achafsex");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
