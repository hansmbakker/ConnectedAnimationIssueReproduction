using System.Collections.Generic;
using ConnectedAnimationIssue.Services;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace ConnectedAnimationIssue.ViewModels
{
    public class SelectedSearchResultViewModel : ViewModelBase
    {
        private GithubIssue _selectedIssue;

        public GithubIssue SelectedIssue
        {
            get => _selectedIssue;
            set => SetProperty(ref _selectedIssue, value);
        }

        public SelectedSearchResultViewModel()
        {
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
            SelectedIssue = e.Parameter as GithubIssue;
        }
    }
}
