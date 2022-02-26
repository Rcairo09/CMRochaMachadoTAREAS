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
    /// <summary>
    /// Interaction logic for Textos.xaml
    /// </summary>
    public partial class Textos : Window
    {
        TextController tc;
        public Textos()
        {
            InitializeComponent();
            inicio();
        }
        public void inicio()
        {
            tc = new TextController(this);
            RoutedEventHandler r = new RoutedEventHandler(tc.TextEventHandler);
            this.btn1.Click += r;
            this.btn2.Click += r;
            this.btnSave.Click += r;
            
        }

        public String setTxt1()
        {
            return "";
        }
    }
}
