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
    /// Interaction logic for ConvertWindow.xaml
    /// </summary>
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
        /*public Conversiones GetData()
        {
            Conversiones conversiones = new Conversiones
            {
                Dia = (DateTime)DatePicker.SelectedDate,
                Cambio1 = Convert1.SelectedValue.ToString(),
                Cambio2 = Convert2.SelectedValue.ToString(),
                Monto1 = Convert.ToDouble(txt1.Text),
                //Monto2 = Convert.ToDouble(txt2.Text)
            };
            return conversiones;
        }
        public void SetData(Conversiones conversiones)
        {
            double x = Convert.ToDouble(txt2.Text);
            x = conversiones.Monto2;
        }*/


    }
}
