
using EjerciciosTarea.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosTarea.Controllers
{
    public class ConvertController
    {
        ConvertWindow cw;
        public ConvertController(ConvertWindow cw)
        {
            this.cw = cw;   
        }
        public void ConvertEventHandler(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btnCalc":
                    realizarCalculo();
                    break;

            }
        }
        public void realizarCalculo()
        {
            if(cw.Convert1.SelectedIndex == 0 && cw.Convert2.SelectedIndex == 1)
            {
                double a = Convert.ToDouble(cw.txt1.Text);
                double result = a / 35.46;
                cw.txt2.Text = Convert.ToString(result);
            }
            else if(cw.Convert1.SelectedIndex == 0 && cw.Convert2.SelectedIndex == 2)
            {
                double a = Convert.ToDouble(cw.txt1.Text);
                double result = a / 39.97;
                cw.txt2.Text = Convert.ToString(result);
            }
            else if (cw.Convert1.SelectedIndex == 1 && cw.Convert2.SelectedIndex == 0)
            {
                double a = Convert.ToDouble(cw.txt1.Text);
                double result = a * 35.46;
                cw.txt2.Text = Convert.ToString(result);
            }
            else if (cw.Convert1.SelectedIndex == 1 && cw.Convert2.SelectedIndex == 2)
            {
                double a = Convert.ToDouble(cw.txt1.Text);
                double result = a * 0.89;
                cw.txt2.Text = Convert.ToString(result);
            }
            else if (cw.Convert1.SelectedIndex == 2 && cw.Convert2.SelectedIndex == 0)
            {
                double a = Convert.ToDouble(cw.txt1.Text);
                double result = a * 39.97;
                cw.txt2.Text = Convert.ToString(result);
            }
            else if (cw.Convert1.SelectedIndex == 2 && cw.Convert2.SelectedIndex == 1)
            {
                double a = Convert.ToDouble(cw.txt1.Text);
                double result = a * 1.13;
                cw.txt2.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Error \nIntente Nuevamente");
            }
        }

        

    }
}
