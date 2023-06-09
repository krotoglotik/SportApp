using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication2.Classes;
using System;

namespace AvaloniaApplication2.Pages
{
    public partial class SportsmanEdit1 : UserControl
    {
        private bool isAdd = true;
        public SportsmanEdit1(Sportsman sportsman)
        {
            InitializeComponent();
            if (sportsman == null)
            {
                DataContext = new Sportsman();
                GenderCb.SelectedIndex = 0;
            }
            else
            {
                isAdd = false;
                DataContext = sportsman;
                GenderCb.SelectedIndex = (sportsman.Gender == "Мужской") ? 0 : 1;
            }
        }
        public SportsmanEdit1()
        {
            InitializeComponent();
        }

        private void okBtnClick(object? sender, RoutedEventArgs args)
        {
            if (String.IsNullOrEmpty(NameTb.Text))
            {
                Helper.ShowInfo("Не заполнено имя.");
                return;
            }

            try
            {
                var sportsman = (Sportsman)DataContext;
                sportsman.Gender = ((ComboBoxItem)GenderCb.SelectedItem).Content.ToString();
                if (isAdd)
                {
                    DataStorage.Sportsmen.Add(sportsman);
                }
                sportsman.BirthDate.ToString("dd.MM.yyyy");
                NavigationSystem.MainFrame.Content = new DataPages1();
            }
            catch (Exception ex)
            {
                Helper.ShowError("Вы не заполнили необходимые поля");
            }
        }

        private void backBtnClick(object? sender, RoutedEventArgs args)
        {
            NavigationSystem.MainFrame.Content = new DataPages1();
        }
    }
}
