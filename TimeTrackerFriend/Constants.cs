using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TimeTrackerFriend
{
    public static class Constants
    {
        public const int labelNumberBasePointX = 2;
        public const int labelNumberBasePointY = 80;
        public const int radioButtonBasePointX = 21;
        public const int radioButtonBasePointY = 88;
        public const int descriptionTextBoxBasePointX = 107;
        public const int descriptionTextBoxBasePointY = 80;
        public const int commentsTextBoxBasePointX = 314;
        public const int commentsTextBoxBasePointY = 80;
        public const int timerTaskLabelBasePointX = 35;
        public const int timerTaskLabelBasePointY = 85;
        public const int initialSlots = 3;
        public const int startButtonBasePointX = 19;
        public const int startButtonBasePointY = 112;
        public const int resetButtonBasePointX = 279;
        public const int resetButtonBasePointY = 112;
        public const int stopButtonBasePointX = 539;
        public const int stopButtonBasePointY = 112;
        public const int addButtonBasePointX = 305;
        public const int addButtonBasePointY = 83;
        public const int deleteButtonBasePointX = 634;
        public const int deleteButtonBasePointY = 83;
        public const int mainHeightBasePointY = 184;
        public const int recordControlHeight = 29;
        public const string baseJiraUrl = "https://bairesdev.atlassian.net";
        public const string logWorkTimeApiPath = "/rest/api/2/issue/{issue}/worklog";
        public const string checkUserApiPath = "/rest/api/3/myself";
    }
}
