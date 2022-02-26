using EjerciciosTarea.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace EjerciciosTarea.Controllers
{
    public class CountriesController
    {
        CountriesWindow cw;
        public CountriesController(CountriesWindow cw)
        {
            this.cw = cw;
        }
        
        public void Departamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            if (cw.Departamentos.SelectedValue != null)
            {
                cw.Municipios.Items.Clear();
                List<string> Managua = new List<string>{
                    "Tipitapa","Ciudad Sandino","El crucero","Mateare","San Francisco Libre",
                    "Ticuantepe"
                };
                foreach (var ok in Managua) {
                    cw.Municipios.Items.Add(ok);
                }
                

            }
            else if (cw.Departamentos.SelectedIndex == 1)
            {
                cw.Municipios.Items.Clear();
                List<string> Leon = new List<string>{
                    "Leon","Achuapa","El jicaral","El sauce","La Paz Centro",
                    "Larreynaga","Nagarote","Quezalguaque"
                };
                foreach (var ok in Leon)
                {
                    cw.Municipios.Items.Add(ok);
                }
            }
            else if (cw.Departamentos.SelectedIndex == 2)
            {
                cw.Municipios.Items.Clear();
                List<string> Chinandega = new List<string>{
                    "Chichigalpa", "Corinto","El Realejo","El Viejo","Posoltega",
                    "Puerto Morazan","Somotillo"
                };
                foreach (var ok in Chinandega)
                {
                    cw.Municipios.Items.Add(ok);
                }
            }
            else if (cw.Departamentos.SelectedIndex == 3)
            {
                cw.Municipios.Items.Clear();
                List<string> Carazo = new List<string>{
                    "Jinotepe", "Diriamba", "Dolores", "El Rosario", "La Conquista", "La Paz","San Marcos"
                };
                foreach (var ok in Carazo)
                {
                    cw.Municipios.Items.Add(ok);
                }
            }
            else if (cw.Departamentos.SelectedIndex == 4)
            {
                cw.Municipios.Items.Clear();
                List<string> Chontales = new List<string>{
                    "Juigalpa", "Acoyapa","Santo Domingo", "San Pedro de Lovago","El Coral","La Libertad",
                    "Santo Tomas"
                };
                foreach (var ok in Chontales)
                {
                    cw.Municipios.Items.Add(ok);
                }
            }
            else if (cw.Departamentos.SelectedIndex == 5)
            {
                cw.Municipios.Items.Clear();
                List<string> Masaya = new List<string>{
                    "Catarina","La Concepcion","Masatepe","Nandasmo","Nindiri","Niquinohomo",
                    "Tisma"
                };
                foreach (var ok in Masaya)
                {
                    cw.Municipios.Items.Add(ok);
                }

            }
        }


        public void showMessage(object sender, SelectionChangedEventArgs e)
        {
            string a = cw.Departamentos.Text;
            string b = cw.Municipios.SelectedItem.ToString();
            MessageBox.Show("Usted ha elegido: "+a +", "+ b); 
            
        }
    }
}
