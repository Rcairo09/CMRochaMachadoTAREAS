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
   
    public partial class ConvertWindow : Window
    {
        ConvertController cc;
        public ConvertWindow()
        {
            InitializeComponent();
            inicio();
        }
        public void inicio()
        {
            cc = new ConvertController(this);
            RoutedEventHandler r = new RoutedEventHandler(cc.ConvertEventHandler);
            this.btnCalc.Click += r;
        }



    }
}
