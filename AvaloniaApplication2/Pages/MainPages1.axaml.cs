using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication2.Classes;
using AvaloniaApplication2.Pages;

namespace AvaloniaApplication2.Pages
{
    public partial class MainPages1 : UserControl
    {
        public MainPages1()
        {
            InitializeComponent();
        }
        private void dataBtnClick(object? sender, RoutedEventArgs args)
        {
            NavigationSystem.MainFrame.Content = new DataPages1();
        }
    }
}
