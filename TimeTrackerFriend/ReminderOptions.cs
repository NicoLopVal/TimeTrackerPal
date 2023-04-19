using System;
using System.ComponentModel;

namespace TimeTrackerFriend
{
    public enum ReminderOptions
    {
        [Description("Message box in the top of the screen")]
        Messenger,

        [Description("Flash being shown in all of the screen")]
        Flash,

    }
}
