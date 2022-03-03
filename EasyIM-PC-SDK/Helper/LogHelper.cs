using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EasyIM_PC_SDK.Helper
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  LogHelper 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2022/3/3 14:02:46 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 14:02:46 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class LogHelper
    {
        private static ILog logger;
        private static ILoggerRepository LoggerRepository;

        static LogHelper()
        {
            LoggerRepository = LogManager.CreateRepository("Log4netConsolePractice");
            var file = new FileInfo("log4net.config");
            XmlConfigurator.ConfigureAndWatch(LoggerRepository, file);
            //logger = LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2));
        }

        /// <summary>
        /// 输出Debug日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void Debug(object message)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).Debug(message);
        }

        /// <summary>
        /// 输出Debug日志
        /// </summary>
        /// <param name="message">消息</param>
        public static void Debug(object message, Exception ex)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).Debug(message, ex);
        }

        /// <summary>
        /// 输出Debug日志
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="args">变量</param>
        public static void DebugFormat(string message, params object[] args)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).DebugFormat(message, args);
        }

        public static void Error(object message)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).Error(message);
        }

        public static void Error(object message, Exception exception)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).Error(message, exception);
        }

        public static void ErrorFormat(string message, params object[] args)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).ErrorFormat(message, args);
        }

        public static void Info(object message)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).Info(message);
        }

        public static void Info(object message, Exception ex)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).Info(message, ex);
        }

        public static void InfoFormat(string message, params object[] args)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCallerType(2)).InfoFormat(message, args);
        }

        public static void Warn(object message)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCurrentMethodFullName()).Warn(message);
        }

        public static void Warn(object message, Exception ex)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCurrentMethodFullName()).Warn(message, ex);
        }

        public static void WarnFormat(string message, params object[] args)
        {
            LogManager.GetLogger(LoggerRepository.Name, GetCurrentMethodFullName()).WarnFormat(message, args);
        }

        /// <summary>
        /// 获得调用者的调用者的声明类型
        /// </summary>
        /// <param name="super">上级级别:1代表上级，2代表上上级，以此类推</param>
        /// <returns></returns>
        private static Type GetCallerType(int super)
        {
            StackTrace trace = new StackTrace();
            return trace.GetFrame(super).GetMethod().DeclaringType;
        }

        private static string GetCurrentMethodFullName()
        {
            StackFrame frame;
            string str;
            string str1;
            bool flag;
            try
            {
                int num = 2;
                StackTrace stackTrace = new StackTrace();
                int length = stackTrace.GetFrames().Length;
                do
                {
                    int num1 = num;
                    num = num1 + 1;
                    frame = stackTrace.GetFrame(num1);
                    str = frame.GetMethod().DeclaringType.ToString();
                    flag = (!str.EndsWith("Exception") ? false : num < length);
                }
                while (flag);
                string name = frame.GetMethod().Name;
                str1 = string.Concat(str, ".", name);
            }
            catch
            {
                str1 = null;
            }
            return str1;
        }
    }
}
