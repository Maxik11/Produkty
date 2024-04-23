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

namespace Produkty
{
    /// <summary>
    /// Interakční logika pro EditWin.xaml
    /// </summary>
    public partial class EditWin : Window
    {

        public Polozka Z { get; set; }
        public EditWin(Polozka z)
        {
            Z = z;
            InitializeComponent();
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Z.Nazev = Nazev.Text;
            Z.Cena = int.Parse(Cena.Text);
            Z.Pocet = int.Parse(Pocet.Text);

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
