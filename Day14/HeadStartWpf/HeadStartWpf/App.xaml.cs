using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Threading;

namespace HeadStartWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += App_Startup;
            this.Exit += App_Exit;
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }

        void App_Exit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("Exiting..... \nBye Bye");
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromMilliseconds(500),DispatcherPriority.Normal,closeSplash,App.Current.Dispatcher); 
            StartupUri = new Uri("Splash.xaml", UriKind.Relative);
        }

        private void closeSplash(object sender, EventArgs e)
        {
            Login mainWindow = new Login();
            var currentWindow = Application.Current.MainWindow;
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            currentWindow.Close();
            DispatcherTimer timer = sender as DispatcherTimer;
            timer.Stop();
        }
    }
}
