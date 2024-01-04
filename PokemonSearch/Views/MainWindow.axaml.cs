using Avalonia.Controls;
using Microsoft.Extensions.DependencyInjection;
using PokemonSearch.ViewModels;

namespace PokemonSearch.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel { get; set; }
        public MainWindow()
        {
            ViewModel = App.GetService<MainWindowViewModel>();
            
            DataContext = ViewModel;
            InitializeComponent();
            //ViewModel = (MainWindowViewModel?)DataContext;
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ViewModel.A++;
        }
    }
}