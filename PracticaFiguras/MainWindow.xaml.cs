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

namespace PracticaFiguras
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Calcularrectangulo_Click(object sender, RoutedEventArgs e)
        {
            double numero1r = double.Parse(txtNumero1r.Text);

            double numero2r = double.Parse(txtNumero2r.Text);

            double resultado = numero1r * numero2r;

            lblArea.Text = resultado.ToString();
        }

        private void Calculartriangulo_Click(object sender, RoutedEventArgs e)
        {
            double numero1tri = double.Parse(txtNumero1tri.Text);

            double numero2tri = double.Parse(txtNumero2tri.Text);

            double resultado = numero1tri * numero2tri / 2;

            lblArea2.Text = resultado.ToString();
        }

        private void Calcularcirculo_Click(object sender, RoutedEventArgs e)
        {
            double numero1c = double.Parse(txtNumero1c.Text);

            double resultado = Math.PI * (numero1c * numero1c);

            lblArea3.Text = resultado.ToString();
        }

        private void Calculartrapecio_Click(object sender, RoutedEventArgs e)
        {
            double numero1tra = double.Parse(txtNumero1tra.Text);

            double numero2tra = double.Parse(txtNumero2tra.Text);

            double numero3tra = double.Parse(txtNumero3tra.Text);

            double resultado = numero3tra * ((numero1tra + numero2tra) / 2);

            lblArea4.Text = resultado.ToString();
        }
    }
}
