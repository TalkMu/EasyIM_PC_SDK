
using EasyIM_PC_SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIMApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IMConfiguration.InitAccessKeyId("51599b3420acb5f2e7d7c2ce9b2b8e90");
            IMConfiguration.SetMsgHandleListener(new MessageCallBackListener());
            Application.Run(new LoginView());
        }
    }
}