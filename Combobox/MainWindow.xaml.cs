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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Combobox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Alumnos> NombreAlumno = new List<Alumnos>();
            NombreAlumno.Add(new Alumnos { NombreAlumno = "Ernesto Calles" });
            NombreAlumno.Add(new Alumnos { NombreAlumno = "Yanira Pocasangre" });

            Alumnos.ItemsSource = NombreAlumno;
        }
    }

    public class Alumnos
    {
        public string NombreAlumno { get; set; }
    }

}
