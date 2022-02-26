using EjerciciosTarea.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EjerciciosTarea.Views
{

    public partial class MainWindow : Window
    {
        MainWindowController mc;
        public MainWindow()
        {
            InitializeComponent();
            inicio();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        public void inicio()
        {
            mc = new MainWindowController(this);
            RoutedEventHandler r = new(mc.MenuItemEventHandler);
            this.configMenu.Click += r;
            this.exitMenu.Click += r;
            this.textMenu.Click += r;
            this.countriesMenu.Click += r;
            this.convertMenu.Click += r;
            this.personWindow.Click += r;
            this.movieWindow.Click += r;
            this.validateWindow.Click += r;

        }
    }
}
