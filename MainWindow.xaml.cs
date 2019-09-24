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

namespace RatonTeclado
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

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FocoTextBox.Text = ((TextBox)sender).Name;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            FocoTextBox.Text = "";
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonTextBox.Text = ((TextBox)sender).Name;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonTextBox.Text = "";
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text.ToUpper();
            TextBox1.CaretIndex = TextBox1.Text.Length;
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBox2.Text = "Ayuda";
            }
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            List<Key> vocales = new List<Key>();
            vocales.Add(Key.A);
            vocales.Add(Key.E);
            vocales.Add(Key.I);
            vocales.Add(Key.O);
            vocales.Add(Key.U);
            if (vocales.Contains(e.Key))
            {
                e.Handled = true;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                BotonIzquierdoTextBox.Background = Brushes.Green;
            }
            if (e.RightButton == MouseButtonState.Pressed)
            {
                BotonDerechoTextBox.Background = Brushes.Green;
            }
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
            {
                BotonIzquierdoTextBox.Background = Brushes.White;
            }
            if (e.RightButton == MouseButtonState.Released)
            {
                BotonDerechoTextBox.Background = Brushes.White;
            }
        }
    }
}
