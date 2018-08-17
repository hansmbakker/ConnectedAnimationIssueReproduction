using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConnectedAnimationIssue.Services
{
    [Headers("User-Agent: Issue reproduction app")]
    public interface IGithubApi
    {
        [Get("/repos/{owner}/{repository}/issues")]
        Task<List<GithubIssue>> GetIssuesAsync(string owner, string repository);
    }

    public class GithubIssue
    {
        public int id { get; set; }
        public string node_id { get; set; }
        public string url { get; set; }
        public string repository_url { get; set; }
        public string labels_url { get; set; }
        public string comments_url { get; set; }
        public string events_url { get; set; }
        public string html_url { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public GithubUser user { get; set; }
        public Label[] labels { get; set; }
        public GithubUser assignee { get; set; }
        public GithubUser[] assignees { get; set; }
        public Milestone milestone { get; set; }
        public bool locked { get; set; }
        public string active_lock_reason { get; set; }
        public int comments { get; set; }
        public Pull_Request pull_request { get; set; }
        public object closed_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class GithubUser
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }

    public class Milestone
    {
        public string url { get; set; }
        public string html_url { get; set; }
        public string labels_url { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public GithubUser creator { get; set; }
        public int open_issues { get; set; }
        public int closed_issues { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? closed_at { get; set; }
        public DateTime? due_on { get; set; }
    }
    
    public class Pull_Request
    {
        public string url { get; set; }
        public string html_url { get; set; }
        public string diff_url { get; set; }
        public string patch_url { get; set; }
    }

    public class Label
    {
        public int id { get; set; }
        public string node_id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public bool _default { get; set; }
    }
}
