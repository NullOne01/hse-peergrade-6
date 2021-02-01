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
            // I tried to use MVVM system here. You can read about it to get idea how program works
            // and why MainForm.cs is so huge.

            // Also I've used this article to implement MVVM: 
            // https://www.codeproject.com/Articles/364485/MVVM-Model-View-ViewModel-Patte

            // Preventing more than one instance of the app.
            if (mutex.WaitOne(TimeSpan.Zero, true)) {
                try {
                    Application.Run(new MainForm());
                } catch (Exception e) {
                    MessageBox.Show("Oh no, error occurred...");
                    MessageBox.Show(e.Message);
                } finally {
                    mutex.ReleaseMutex();
                }
            } else {
                MessageBox.Show("Already running");
            }
        }
    }
}
