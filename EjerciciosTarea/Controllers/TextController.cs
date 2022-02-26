using EjerciciosTarea.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosTarea.Controllers
{
    public class TextController
    {
        Textos t;
        SaveFileDialog saveFile;
        OpenFileDialog openFile;
        private string text1, text2;

        public TextController(Textos t)
        {
            this.t = t;
            saveFile = new SaveFileDialog();
            openFile = new OpenFileDialog();
        }
        public void TextEventHandler(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btn1":
                    open1();
                    break;
                case "btn2":
                    open2();
                    break;
                case "btnSave":
                    save();
                    break;
            }
        }
        public void open1()
        {
            openFile.Filter = "Txt File (*.txt)|*.txt";
            if (openFile.ShowDialog() == true)
            {
                t.txt1.Text = openFile.FileName;
                var fileStream = openFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    if (t.txt3.Text != null)
                    {
                        text1 = text2 + " " + reader.ReadToEnd();
                        t.txt3.Text = text1;
                    }
                    else
                    {
                        text1 = reader.ReadToEnd();
                        t.txt3.Text = text1;
                    }
                }
            }
        }
        public void open2()
        {
            openFile.Filter = "Txt File (*.txt)|*.txt";
            if (openFile.ShowDialog() == true)
            {
                t.txt2.Text = openFile.FileName;
                var fileStream = openFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    if (t.txt3.Text != null)
                    {
                        text2 = text1 + " " + reader.ReadToEnd();
                        t.txt3.Text = text2;
                    }
                    else
                    {
                        text2 = reader.ReadToEnd();
                        t.txt3.Text = text2;
                    }
                }
            }
        }

        public void save()
        {
            if(saveFile.ShowDialog() == true)
            {
                if (File.Exists(saveFile.FileName))
                {
                    string txt = saveFile.FileName;
                    StreamWriter texto = File.CreateText(txt);
                    texto.Write(t.txt3.Text);
                    texto.Flush();
                    texto.Close();
                }
                else
                {
                    string txt = saveFile.FileName;
                    StreamWriter texto = File.CreateText(txt);
                    texto.Write(t.txt3.Text);
                    texto.Flush();
                    texto.Close();
                }
            }
        }
    }
}
