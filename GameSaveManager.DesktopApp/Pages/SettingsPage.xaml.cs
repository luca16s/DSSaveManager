﻿namespace GameSaveManager.DesktopApp.Pages
{
    using GameSaveManager.DesktopApp.ViewModel;

    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
            DataContext = new SettingsPageViewModel();
        }
    }
}