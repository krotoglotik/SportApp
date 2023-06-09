using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication2.Classes;
using MessageBox.Avalonia;
using System.Collections.Generic;

namespace AvaloniaApplication2.Pages
{
    public partial class DataPages1 : UserControl
    {
        public DataPages1()
        {
            InitializeComponent();
            loadData();
        }

        private void searchTbKeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            if (string.IsNullOrEmpty(SearchTb.Text))
            {
                SportsmanDG.Items = DataStorage.Sportsmen;
            }
            else
            {
                var filteredSportsmen = new List<Sportsman>();
                foreach (var el in DataStorage.Sportsmen)
                {
                    if (el.Name.Contains(SearchTb.Text))
                    {
                        filteredSportsmen.Add(el);
                    }
                }
                SportsmanDG.Items = filteredSportsmen;
            }


        }

        private static void backBtnClick(object? sender, RoutedEventArgs args)
        {
            NavigationSystem.MainFrame.Content = new MainPages1();
        }

        private void addSportsmanBtnClick(object? sender, RoutedEventArgs args)
        {
            NavigationSystem.MainFrame.Content = new SportsmanEdit1(null);
        }

        private void editSportsmanBtnClick(object? sender, RoutedEventArgs args)
        {
            var selectedSportsman = (Sportsman)SportsmanDG.SelectedItem;
            if (selectedSportsman == null)
            {
                Helper.ShowInfo("Выберите спортсмена");
                return;
            }
            NavigationSystem.MainFrame.Content = new SportsmanEdit1(selectedSportsman);
        }

        private async void deleteSportsmanBtnClick(object? sender, RoutedEventArgs args)
        {
            var selectedSportsman = (Sportsman)SportsmanDG.SelectedItem;
            if (selectedSportsman == null)
            {
                Helper.ShowInfo("Выберите спортсмена");
                return;
            }
            var answer = await MessageBoxManager.GetMessageBoxStandardWindow("Вопрос", "Вы уверены?",
                MessageBox.Avalonia.Enums.ButtonEnum.YesNo, MessageBox.Avalonia.Enums.Icon.Question).Show();
            if (answer == MessageBox.Avalonia.Enums.ButtonResult.Yes)
            {
                DataStorage.Sportsmen.Remove(selectedSportsman);
            }
        }
    }
}
