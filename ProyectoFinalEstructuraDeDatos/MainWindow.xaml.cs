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
using System.Collections.ObjectModel;

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Elementos> element = new ObservableCollection<Elementos>();
        public MainWindow()
        {
            InitializeComponent();

            element.Add(new Elementos("La gran masacre", 1998, "Terror", "5 estudiantes, un destino.", "3", "Josh Smith", "4"));
            element.Add(new Elementos("Al pan pan y al vino vino...", 2006, "Comedia", "Adivina adivinador, de que se trata el título de hoy?.", "5", "Apakh Sultanu", "3"));
            element.Add(new Elementos("La llama en llamas", 2017, "Comedia, Acción", "¿Qué pasará con la llama en llamas que llama a su llama?.", "15", "Pedrito Alfonsito Rodriguez", "5"));
            element.Add(new Elementos("Pepito clavo un clavito", 1967, "Fantasía", "Pepito, el niño que clava clavitos.", "8", "Millie Sugar", "1"));
            element.Add(new Elementos("El amor de mi vida", 2019, "Aaron esta enamorado de su compañero de clase Hyde, un amor incomprendido.", "7", "Ariel Paccino", "5"));
            listViewMain.ItemsSource = element;
        }

        private void BtnAgregarNuevoElemento_Click(object sender, RoutedEventArgs e)
        {
            grdContenido.Children.Add(new agregarElemento());
            btnLetra1.Visibility = Visibility.Hidden;
            btnLetra2.Visibility = Visibility.Hidden;
            btnNumero1.Visibility = Visibility.Hidden;
            btnNumero2.Visibility = Visibility.Hidden;
        }

        private void BtnNum1_Click(object sender, RoutedEventArgs e)
        {
            {
                int gap, i;
                gap = element.Count / 2;


                while (gap > 0)
                {

                    for (i = 0; i < element.Count; i++)
                    {
                        if (gap + i < element.Count && element[i].Año > element[gap + i].Año)
                        {

                            var temp = element[i];
                            element[i] = element[gap + i];
                            element[gap + i] = temp;
                        }
                    }

                    gap--;
                }

            }
        }

        private void BtnNum2_Click(object sender, RoutedEventArgs e)
        {
            {
                int gap, i;
                gap = element.Count / 2;


                while (gap > 0)
                {

                    for (i = 0; i < element.Count; i++)
                    {
                        if (gap + i < element.Count && element[i].Año < element[gap + i].Año)
                        {

                            var temp = element[i];
                            element[i] = element[gap + i];
                            element[gap + i] = temp;
                        }
                    }

                    gap--;
                }

            }
        }

        private void LstViewMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdContenido.Children.Clear();
            grdContenido.Children.Add(new Editar());
            // (((Agregar)(gridprincipal.Children)).txtaño.Text);
            //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);

            btnEliminar.Visibility = Visibility.Visible;
            //editar.Visibility = Visibility.Visible;
            ((Editar)(grdContenido.Children[0])).txtTitulo.Text = element[listViewMain.SelectedIndex].Titulo;
            ((Editar)(grdContenido.Children[0])).txtSinopsis.Text = element[listViewMain.SelectedIndex].Sinopsis;
            ((Editar)(grdContenido.Children[0])).txtSinopsis.Text = element[listViewMain.SelectedIndex].Descripcion;
            ((Editar)(grdContenido.Children[0])).txtProductor.Text = element[listViewMain.SelectedIndex].Director;
            ((Editar)(grdContenido.Children[0])).txtProductor.Text = element[listViewMain.SelectedIndex].Productor;
            ((Editar)(grdContenido.Children[0])).cbGenero.Text = element[listViewMain.SelectedIndex].Genero;
            ((Editar)(grdContenido.Children[0])).cbTemporadas.Text = element[listViewMain.SelectedIndex].Temporadas;
            ((Editar)(grdContenido.Children[0])).cbRanting.Text = element[listViewMain.SelectedIndex].Ranting;
            ((Editar)(grdContenido.Children[0])).txtAño.Text = element[listViewMain.SelectedIndex].Año.ToString();

        }

    }
}
