using ACM.Common.Library;
using ACM.Common.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ACM.DefensiveProgramming.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //For UNI Thread Exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            //Force all Windows Forms errors to go through our handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //For non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PedometerWin());
        }

        static void GlobalExceptionHandler(object sender, EventArgs e)
        {

            ApplicationLog applicationLog = new ApplicationLog(e);

            if (!applicationLog.Log().IsEmpty())
            {
                LoggingService.WriteToFile(new List<ILoggable> { applicationLog });
                Application.Exit();
            }
        }

        private class ApplicationLog : ILoggable
        {
            private string _logMessage;
            public ApplicationLog(EventArgs eventArgs)
            {
                if (eventArgs is UnhandledExceptionEventArgs)
                {
                    var error = eventArgs as UnhandledExceptionEventArgs;
                    _logMessage = ((Exception)error.ExceptionObject).GetFullErrorMessage();
                }
                else if (eventArgs is ThreadExceptionEventArgs)
                {
                    var error = eventArgs as ThreadExceptionEventArgs;
                    _logMessage = error.Exception.GetFullErrorMessage();
                }
            }
            public string Log()
            {
                return _logMessage;
            }
        }
    }
}
