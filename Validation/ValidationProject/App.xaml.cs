using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using ValidationProject.View;
using ValidationProject.ViewModels;

namespace ValidationProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DataViewModels dataViewModels = new DataViewModels();
            MainWindow window = new MainWindow();
            window.DataContext = dataViewModels;
            window.Show();
            base.OnStartup(e);
        }
    }
}
