using My_Confrence_App.Pages;
using My_Confrence_App.ViewModels;

namespace My_Confrence_App;

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

		builder.Services.AddTransient<SchedulePage>();
		builder.Services.AddTransient<ScheduleViewModel>();
        builder.Services.AddTransient<SponsorsPage>();
        builder.Services.AddTransient<AgendaPage>();

        return builder.Build();
	}
}
