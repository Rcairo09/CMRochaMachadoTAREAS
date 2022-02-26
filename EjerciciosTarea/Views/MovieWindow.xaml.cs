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
    /// Interaction logic for MovieWindow.xaml
    /// </summary>
    public partial class MovieWindow : Window
    {
        double a, b;
        public MovieWindow()
        {
            InitializeComponent();
            
        }

        private void cboxChecked(object sender, RoutedEventArgs e)
        {
            if(cboxMovie.SelectedIndex == 0)
            {
                if (cbox2D.IsChecked == true)
                {
                    cbox3D.IsChecked = false;
                    a = 140;
                    b = 120;
                    labelAdults.Content = "C$ "+a;
                    labelKids.Content = "C$ "+b;
                    

                }
                else if (cbox3D.IsChecked == true)
                {
                    cbox2D.IsChecked = false;
                    double a = 180;
                    double b = 150;
                    labelAdults.Content = "C$ " + a;
                    labelKids.Content = "C$ " + b;
                    if (txtAdult != null && txtKids != null)
                    {
                        double textAdults = Convert.ToDouble(txtAdult.Text);
                        double textKids = Convert.ToDouble(txtKids.Text);
                        double result = (a * textAdults) + (b * textKids);
                        labelPagar.Content = result;

                    }


                }
            }
            
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtAdult.Text != null && txtKids.Text != null)
            {
                double textAdults = Convert.ToDouble(txtAdult.Text);
                double textKids = Convert.ToDouble(txtKids.Text);
                double result = (a * textAdults) + (b * textKids);
                labelPagar.Content = result;
            }

        }

  

        //private double btnCalc_Click(object sender, RoutedEventArgs e, double adults, double kids)
        //{
        //    double result = 0;
        //    if(txtAdult != null && txtKids != null)
        //    {
        //        double textAdults = Convert.ToDouble(txtAdult.Text);
        //        double textKids = Convert.ToDouble(txtKids.Text);
        //        result = (adults * textAdults) + (kids * textKids);

        //    }
        //    else
        //    {
        //        MessageBox.Show("Ingrese el numero de Boletos \nSino comprará, digite el numero 0");
        //    }
        //    return result;
        //}

    }
}
