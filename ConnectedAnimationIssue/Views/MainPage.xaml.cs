using System;

using ConnectedAnimationIssue.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ConnectedAnimationIssue.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
