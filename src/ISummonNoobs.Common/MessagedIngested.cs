﻿using Eshopworld.Core;

namespace ISummonNoobs.Common
{
    public class MessagedIngested : TelemetryEvent
    {
        public string MessageType { get; set; }

        public string Payload { get; set; }
    }
}
