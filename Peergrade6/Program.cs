using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peergrade6
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, Assembly.GetEntryAssembly().GetName().Name);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // I used MVVM system here.

            // Preventing more than one instance of the app.
            if (mutex.WaitOne(TimeSpan.Zero, true)) {
                try {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                } catch {
                    MessageBox.Show("Oh no, error occurred...");
                }
                finally {
                    mutex.ReleaseMutex();
                }
            } else {
                MessageBox.Show("Already running");
            }
        }
    }
}
