using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Produkty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Polozka> Polozka { get; set; }
        public MainWindow()
        {
            Polozka = new();
            InitializeComponent();
            seznam.ItemsSource = Polozka;
        }

        private void Pridat_Click(object sender, RoutedEventArgs e)
        {
            PridatWin dialog = new(Polozka);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Polozka;
        }

        private void Zobrazit_Click(object sender, RoutedEventArgs e)
        {
            Polozka? info = seznam?.SelectedItem as Polozka ?? new Polozka(-1, "Neznámý" , -1,- 1 );
            MessageBox.Show($" ID:{info.Id} \n Název Produktu:{info.Nazev} \n Počet Položek:{info.Pocet} \n Cena:{info.Cena}");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Polozka? info = seznam?.SelectedItem as Polozka ?? new Polozka(-1, "Neznámý", -1, -1);
            Polozka? hledany = seznam?.SelectedItem as Polozka;
            if (hledany != null)
            {
                EditWin edit = new EditWin(hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }


        }

        private void Odebrat_Click(object sender, RoutedEventArgs e)
        {
            Polozka? hledany = seznam?.SelectedItem as Polozka;
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledany.Nazev}?", "Odebrat", MessageBoxButton.YesNo);
            if (volba == MessageBoxResult.Yes)
            {
                Polozka.Remove(hledany);
                seznam.ItemsSource = null;
                seznam.ItemsSource = Polozka;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}