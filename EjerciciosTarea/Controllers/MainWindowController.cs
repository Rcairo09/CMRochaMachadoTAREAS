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
    public class MainWindowController
    {
        MainWindow mainWindow;
        public MainWindowController(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void MenuItemEventHandler(object sender, RoutedEventArgs e)
        {
            MenuItem menu = (MenuItem)sender;
            switch (menu.Name)
            {
                case "configMenu":
                    showConfig();
                    break;
                case "exitMenu":
                    Environment.Exit(0);
                    break;
                case "textMenu":
                    showText();
                    break;
                case "convertMenu":
                    showConvertWindow();
                    break;
                case "countriesMenu":
                    showCountriesMenu();
                    break;
                case "personWindow":
                    showPerson();
                    break;
                case "validateWindow":
                    showValidate();
                    break;
                case "movieWindow":
                    showMovie();
                    break;
                
            }
        }

        private void showPerson()
        {
            PersonWindow personWindow = new PersonWindow();
            personWindow.Show();
        }

        private void showValidate()
        {
            ValidateWindow validateWindow = new ValidateWindow();
            validateWindow.Show();
        }

        private void showMovie()
        {
            MovieWindow movieWindow = new MovieWindow();
            movieWindow.Show();
        }

        private void showCountriesMenu()
        {
            CountriesWindow countriesWindow = new CountriesWindow();
            countriesWindow.Show();
        }

        public void showText()
        {
            Textos textos = new Textos();
            textos.Show();
        }

        public void showConvertWindow()
        {
            ConvertWindow convertWindow = new ConvertWindow();
            convertWindow.Show();
        }

        public void showConfig()
        {
            MessageBox.Show("CONFIGURACION");
        }
    }
}
