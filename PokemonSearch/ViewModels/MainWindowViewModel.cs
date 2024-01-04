using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PokemonSearch.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] object _contentC = App.GetService<SearchViewModel>();
        [ObservableProperty]
        int  _a = 0;
#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static


        [RelayCommand]
        public void Test() => ++A;
        
    }
}
