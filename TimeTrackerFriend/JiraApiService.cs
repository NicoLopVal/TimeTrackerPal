using Atlassian.Jira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Newtonsoft.Json;

namespace TimeTrackerFriend
{
    class JiraApiService
    {
        private byte[] _authData;
        private string _basicauth;
        public JiraApiService(string userName, string token)
        {
            _authData = System.Text.Encoding.UTF8.GetBytes($"{userName}:{token}");
            _basicauth = Convert.ToBase64String(_authData);
        }

        public bool CheckJiraConnection()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Constants.baseJiraUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _basicauth);

                var result = client.GetAsync(Constants.checkUserApiPath).Result;
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    return true;
                else
                    return false;
            }
        }

        public string LogWorkTime(string issue, int timeInSeconds, string comment, DateTime started)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Constants.baseJiraUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _basicauth);

                var data = new
                {
                    timeSpentSeconds = timeInSeconds,
                    Comment = new
                    {
                        type = "doc",
                        version = 1,
                        content = new[]
                        {
                        new
                        {
                            type = "paragraph",
                            content = new[]
                            {
                                new
                                {
                                    text = comment,
                                    type = "text"
                                }
                            }
                        }
                    }
                    },
                    Started = started.ToString(),
                };
                string jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var result = client.PostAsync(Constants.logWorkTimeApiPath.Replace("{issue}", issue), content).Result;
                if (result.StatusCode == System.Net.HttpStatusCode.Created)
                    return "Success";
                else
                    return "Failture";
            }
        }

        public void SaveToJira(frmMainWindow mainForm)
        {
            var taskDescriptions = mainForm.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("descriptionTaskTextBox"));

            foreach(var task in taskDescriptions)
            {
                if (!SharedFunctions.HasJiraTaskCodeFormat(task.Text))
                    continue;

                var issue = task.Text;
                var taskIndex = SharedFunctions.RemoveNonNumericCharacters(task.Name);
                var comment = mainForm.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name.Equals("commentsTaskTextBox" + taskIndex)).Text;
                var timer = (NamedTimer)mainForm._timers.FirstOrDefault(t => ((NamedTimer)t).Name.Equals("TaskTimer" + taskIndex));

                LogWorkTime(issue, timer.TotalSeconds(), comment, DateTime.Now);
            }
        }
    }
}
