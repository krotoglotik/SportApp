using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication2.Classes;
using AvaloniaApplication2.Pages;
using System;

namespace AvaloniaApplication2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new MainPages1();
            NavigationSystem.MainFrame = MainFrame;
        }

        private void exitBtnClick(object? sender, RoutedEventArgs args)
        {
            Close();
        }
    }
}