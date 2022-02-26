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
    /// Interaction logic for CountriesWindow.xaml
    /// </summary>
    public partial class CountriesWindow : Window
    {
        CountriesController cc;
        string[] Depar = { "Chontales", "Carazo", "Managua" };
        string[] Chontales = { "Juigalpa", "Acoyapa", "El coral" };
        string[] Carazo = { "Jinotepe", "Diriamba", "San Marcos" };
        public CountriesWindow()
        {
            cc = new CountriesController(this);
            InitializeComponent();
            Departamentos.SelectionChanged += new SelectionChangedEventHandler(cc.Departamentos_SelectionChanged);
            Municipios.SelectionChanged += new SelectionChangedEventHandler(cc.showMessage);
        }

        
    }
}
