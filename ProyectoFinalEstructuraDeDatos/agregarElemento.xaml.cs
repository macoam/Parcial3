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

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para agregarElemento.xaml
    /// </summary>
    public partial class agregarElemento : UserControl
    {
        public agregarElemento()
        {
            InitializeComponent();
        }

        private void RdbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdContenidoDeSerieYPelicula.Children.Clear();
            grdContenidoDeSerieYPelicula.Children.Add(new usuarioPelicula());
        }

        private void RdbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdContenidoDeSerieYPelicula.Children.Clear();
            grdContenidoDeSerieYPelicula.Children.Add(new usuarioSerie());
        }
    }
}
