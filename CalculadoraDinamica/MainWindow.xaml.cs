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

namespace CalculadoraDinamica
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CrearBotonesCalculadora();
        }

        private void CrearBotonesCalculadora()
        {
            Button button;
            Viewbox viewbox;
            TextBlock textBlock;
            int tag = 1;

            for (int j = 2; j <= 4; j++)
            {
                for (int i = 0; i <= 2; i++)
                {
                    button = new Button();
                    button.Style = (Style)this.Resources["Botones"];
                    PrincipalGrid.Children.Add(button);
                    Grid.SetColumn(button, i);
                    Grid.SetRow(button, j);
                    button.Tag = tag;
                    viewbox = new Viewbox();
                    button.Content = viewbox;
                    textBlock = new TextBlock();
                    textBlock.Text = tag.ToString();
                    viewbox.Child = textBlock;
                    tag++;
                }
            }
        }
        private void botonNumeroClick(object sender, RoutedEventArgs e)
        {

            Button botonNumero = (Button)sender;
            NumerosTextBlock.Text += botonNumero.Tag;

        }
    }
}
