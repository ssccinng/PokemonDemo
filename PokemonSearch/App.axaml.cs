using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using PokemonSearch.ViewModels;
using PokemonSearch.Views;

namespace PokemonSearch
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }

        public static T GetService<T>() =>
            (Current as App).ServiceProvider.GetRequiredService<T>();
        
        public override void Initialize()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MainWindowViewModel>();
            serviceCollection.AddSingleton<MainWindow>();

            serviceCollection.AddSingleton<SearchViewModel>();
            serviceCollection.AddSingleton<SearchView>();

            
            ServiceProvider = serviceCollection.BuildServiceProvider();
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Line below is needed to remove Avalonia data validation.
                // Without this line you will get duplicate validations from both Avalonia and CT
                BindingPlugins.DataValidators.RemoveAt(0);
                desktop.MainWindow = new MainWindow
                {
                    // DataContext = ServiceProvider.GetRequiredService<MainWindowViewModel>()
                };
                
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}