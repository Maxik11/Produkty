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
    /// Interakční logika pro PridatWin.xaml
    /// </summary>
    public partial class PridatWin : Window
    {
        List<Polozka> _polozky;
        public PridatWin(List<Polozka> polozky)
        {
            _polozky = polozky;
            InitializeComponent();
        }

        public PridatWin(Polozka hledany)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int VytvorId() => _polozky.Count + 1;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nazev = Nazev.Text;
            int cena = int.Parse(Cena.Text);
            int pocet =int.Parse(Pocet.Text);

            Polozka Novy = new Polozka(VytvorId(), nazev, cena, pocet);
            _polozky.Add(Novy);

            this.Close();
        }
    }
}
