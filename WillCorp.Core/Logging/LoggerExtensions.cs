﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillCorp.Logging
{
    /// <summary>
    /// This class provides helper methods for the ILogger interface
    /// which makes using the logger easier and more explicit
    /// </summary>
    public static class LoggerExtensions
    {
        #region Error Methods
        public static void Error(this ILogger logger, string message)
        {
            logger.Log(new LogItem(LogLevel.Error, message));
        }
        public static void Error(this ILogger logger, System.Exception exception)
        {
            logger.Log(new LogItem(LogLevel.Error, "Unexpected error occured", exception));
        }
        public static void Error(this ILogger logger, string message, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Error, message, null, args));
        }
        public static void Error(this ILogger logger, System.Exception exception, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Error, "Unexpected error occured", exception, args));
        }
        public static void Error(this ILogger logger, string message, System.Exception exception, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Error, message, exception, args));
        }
        #endregion

        #region Information Methods
        public static void Information(this ILogger logger, string message)
        {
            logger.Log(new LogItem(LogLevel.Information, message));
        }
        public static void Information(this ILogger logger, string message, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Information, message, null, args));
        }
        #endregion

        #region Warn Methods
        public static void Warn(this ILogger logger, string message)
        {
            logger.Log(new LogItem(LogLevel.Warning, message));
        }
        public static void Warn(this ILogger logger, string message, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Warning, message, null, args));
        }
        #endregion

        #region Debug Methods
        public static void Debug(this ILogger logger, string message)
        {
            logger.Log(new LogItem(LogLevel.Debug, message));
        }
        public static void Debug(this ILogger logger, string message, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Debug, message, null, args));
        }
        #endregion

        #region Verbose Methods
        public static void Verbose(this ILogger logger, string message)
        {
            logger.Log(new LogItem(LogLevel.Verbose, message));
        }
        public static void Verbose(this ILogger logger, string message, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Verbose, message, null, args));
        }
        #endregion

        #region Fatal Methods
        public static void Fatal(this ILogger logger, string message)
        {
            logger.Log(new LogItem(LogLevel.Fatal, message));
        }
        public static void Fatal(this ILogger logger, System.Exception exception)
        {
            logger.Log(new LogItem(LogLevel.Fatal, "Unexpected error occured", exception));
        }
        public static void Fatal(this ILogger logger, string message, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Fatal, message, null, args));
        }
        public static void Fatal(this ILogger logger, System.Exception exception, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Fatal, "Unexpected error occured", exception, args));
        }
        public static void Fatal(this ILogger logger, string message, System.Exception exception, params object[] args)
        {
            logger.Log(new LogItem(LogLevel.Fatal, message, exception, args));
        }
        #endregion
    }
}
