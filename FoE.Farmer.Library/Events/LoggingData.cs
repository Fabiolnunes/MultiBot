﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoE.Farmer.Library.Events
{
    public class LoggingDataEventArgs : EventArgs
    {
        public string Message { get; set; }
        public LogMessageType Type { get; set; }
    }
}
