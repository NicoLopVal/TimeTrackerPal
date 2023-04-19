using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerFriend
{
    class WorklogJiraInput
    {
        private string Comment;
        private int TimeSpendInSeconds;

        public WorklogJiraInput(string comment, int timeSpendInSeconds)
        {
            Comment = comment;
            TimeSpendInSeconds = timeSpendInSeconds;
        }
    }
}
