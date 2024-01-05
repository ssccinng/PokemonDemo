using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using PokemonSearch.ViewModels;

namespace PokemonSearch.Views;

public partial class SearchView : UserControl
{
    public SearchViewModel ViewModel { get; }

    public TextBox[] ValueTestBoxes { get; set; } = new TextBox[18];
    public SearchView()
    {
        DataContext = ViewModel = App.GetService<SearchViewModel>();
        InitializeComponent();
    }

    private void UserControl_Loaded(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        for (int i = 0; i < 6; i++)
        {
            StackPanel panel = new StackPanel { 
                Spacing = 10,
                Orientation = Avalonia.Layout.Orientation.Horizontal, 
                Margin = new Thickness(0,10,0,0)
            };
            var valBase = ValueTestBoxes[i * 3 + 0] = new TextBox { Text = "0", MinWidth = 60 };
            var valIv = ValueTestBoxes[i * 3 + 1] = new TextBox { Text = "0", MinWidth = 60 };
            var valEv = ValueTestBoxes[i * 3 + 2] = new TextBox { Text = "0", MinWidth = 60 };
            panel.Children.Add(new Label { Content = "攻击", Width = 60, VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center });
            panel.Children.Add(valBase);
            panel.Children.Add(valIv);
            panel.Children.Add(valEv);
            panel.Children.Add(new Label { Content = "0", MinWidth = 60, Margin = new Thickness(10,0,0,0), VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center });
            ValueStack.Children.Add(panel);
        }
    }


    void Update()
    {

    }
}