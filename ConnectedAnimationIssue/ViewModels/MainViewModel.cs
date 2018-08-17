using ConnectedAnimationIssue.Services;
using Prism.Commands;
using Prism.Windows.AppModel;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ConnectedAnimationIssue.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IGithubApi _githubApi;

        [RestorableState]
        public ObservableCollection<GithubIssue> SearchResults { get; set; }

        private string _repoName;
        private string _repoOwner;

        [RestorableState]
        public string RepoOwner
        {
            get => _repoOwner;
            set => SetProperty(ref _repoOwner, value);
        }

        [RestorableState]
        public string RepoName
        {
            get => _repoName;
            set => SetProperty(ref _repoName, value);
        }

        public DelegateCommand SearchCommand { get; set; }

        public MainViewModel(INavigationService navigationService, IGithubApi githubApi)
        {
            _navigationService = navigationService;
            _githubApi = githubApi;

            SearchResults = new ObservableCollection<GithubIssue>();

            SearchCommand = new DelegateCommand(async () => await PerformSearchAsync());
        }

        private async Task PerformSearchAsync()
        {
            SearchResults.Clear();

            if(string.IsNullOrWhiteSpace(RepoOwner) || string.IsNullOrWhiteSpace(RepoName))
            {
                return;
            }

            List<GithubIssue> issues;
            try
            {
                issues = await _githubApi.GetIssuesAsync(RepoOwner, RepoName);
            }
            catch(Exception ex)
            {
                return;
            }

            foreach(var issue in issues)
            {
                SearchResults.Add(issue);
            }
        }

        public void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as GithubIssue;
            _navigationService.Navigate(PageTokens.SelectedSearchResultPage, item);

        }
    }
}
