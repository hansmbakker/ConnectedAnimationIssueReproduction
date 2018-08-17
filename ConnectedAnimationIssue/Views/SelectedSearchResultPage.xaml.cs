using System;

using ConnectedAnimationIssue.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ConnectedAnimationIssue.Views
{
    public sealed partial class SelectedSearchResultPage : Page
    {
        private SelectedSearchResultViewModel ViewModel => DataContext as SelectedSearchResultViewModel;

        public SelectedSearchResultPage()
        {
            InitializeComponent();
        }
    }
}
