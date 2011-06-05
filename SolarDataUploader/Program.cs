using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Utility.Interaction.ExceptionHandler;

namespace SolarDataUploader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ExceptionHandlerConfiguration ehc = new ExceptionHandlerConfiguration();
            ehc.gitHubRepository = "stwalkerster/solar-uploader";
            ehc.contactEmailAddress = "solar@helpmebot.org.uk";
            ehc.showTechnicalInformation = true;
            ehc.bugTracker = "https://github.com/stwalkerster/solar-uploader/issues";
            ExceptionHandler.setConfiguration(ehc);

            Application.ThreadException += ExceptionHandler.threadExceptionEventHandler;
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler.currentDomainUnhandledExceptionHandler;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

    }
}
