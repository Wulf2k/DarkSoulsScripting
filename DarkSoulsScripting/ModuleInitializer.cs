// This file can be modified in any way, with two exceptions. 1) The name of
// this class must be "ModuleInitializer". 2) This class must have a public or
// internal parameterless "Run" method that returns void. In addition to these
// modifications, this file may also be moved to any location, as long as it
// remains a part of its current project.

using System;
using System.Threading;
using System.Windows;

namespace DarkSoulsScripting
{
    internal static class ModuleInitializer
    {
        public static SafetyFinalizerHandler Finalizer = null;

        internal static void Run()
        {
            if (!Hook.DARKSOULS.TryAttachToDarkSouls(out string error))
            {
                if (MessageBox.Show(error + "\n\nWould you like to proceed anyways?", "Failed to attach to Dark Souls", MessageBoxButton.YesNo, MessageBoxImage.Warning) != MessageBoxResult.Yes)
                {
                    if (System.Windows.Application.Current != null) //WPF
                        System.Windows.Application.Current.Shutdown();
                    else if (System.Windows.Forms.Application.MessageLoop) //WinForms
                        System.Windows.Forms.Application.Exit();
                    else //Console application
                        Environment.Exit(1);
                    Application.Current.Shutdown(1);
                    return;
                }
            }

            Finalizer = new SafetyFinalizerHandler();
        }

        public class SafetyFinalizerHandler
        {
            Thread CleanExitThread;
            EventWaitHandle CleanExitTrigger = new EventWaitHandle(false, EventResetMode.ManualReset);

            public SafetyFinalizerHandler()
            {
                CleanExitThread = new Thread(new ThreadStart(DoCleanExitWait));
                CleanExitThread.Start();
            }

            private void DoCleanExitWait()
            {
                bool doCleanExit = false;

                try
                {
                    do
                    {
                        doCleanExit = CleanExitTrigger.WaitOne(5000);
                    } while (!(doCleanExit));

                }
                catch
                {

                }
                finally
                {
                    GC.KeepAlive(this);
                }
            }

            ~SafetyFinalizerHandler()
            {
                Hook.ASM.Dispose();
                Hook.DARKSOULS.Close();
            }
        }
    }
}