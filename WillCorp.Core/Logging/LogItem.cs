﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillCorp.Logging
{
    public class LogItem
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public object[] FormatParameters { get; set; }

        public LogItem(LogLevel logLevel, string message)
            : this(logLevel, message, null)
        {

        }

        public LogItem(LogLevel logLevel, string message, Exception exception = null, params object[] formatParameters)
        {
            LogLevel = logLevel;
            Message = message;
            Exception = exception;
            FormatParameters = formatParameters;
        }

    }
}
