﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Maui9Issues
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            RegisterViews(builder.Services);

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        static void RegisterViews(IServiceCollection services)
        {
            services.AddTransient<MainPageViewModel>();
            services.AddTransient<Page2ViewModel>();

            services.AddTransient<MainPage>();
            services.AddTransient<Page2>();
        }
    }
}