using Telerik.Maui.Controls.Compatibility;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Gestor_Tareas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseTelerik()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Comic.otf", "Comic");
                    fonts.AddFont("IHATCS__.TTF", "Comic-Sans");
                    fonts.AddFont("Santa-Catalina1.otf", "Santa");
                });

            return builder.Build();
        }
    }
}
