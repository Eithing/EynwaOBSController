using System;
using System.Collections.Generic;
using System.Text;

namespace EynwaObsController.Model
{
    public class Event
    {
        public EventType Type { get; set; }
        public ulong Delay { get; set; }
        public string Name { get; set; }
    }

    public enum EventType
    {
        TextChatDetector,
    }
}
