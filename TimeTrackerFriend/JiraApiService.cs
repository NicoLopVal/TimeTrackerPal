using Atlassian.Jira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerFriend
{
    class JiraApiService
    {
        private string _userName;
        private string _token;
        public JiraApiService(string userName, string token)
        {
            _userName = userName;
            _token = token;
        }

        private Jira CreateJiraConnection()
        {
            return Jira.CreateRestClient(Constants.baseJiraUrl, _userName, _token);
        }

        public void LogTimeToJira(string issueKey, string comments, string timeSpent) //string comments, int seconds
        {
            var jiraConnection = CreateJiraConnection();
            var jiraWorklog = new Atlassian.Jira.Worklog(timeSpent,DateTime.Today, comments);
            jiraConnection.Issues.AddWorklogAsync(issueKey, jiraWorklog).Wait();
        }

        public bool ValidateCredentials()
        {
            try
            {
                var jiraConnection = CreateJiraConnection();
                var currentUser = jiraConnection.Users.GetMyselfAsync().Result;
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
