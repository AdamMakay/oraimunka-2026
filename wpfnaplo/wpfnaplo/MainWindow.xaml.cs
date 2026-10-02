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

namespace wpfnaplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slidJegy(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            jegy.Content = Slidjegy.Value.ToString();
        }

        private void naplobaRogzites(object sender, RoutedEventArgs e)
        {
            lbjegyek.Items.Add($"{nev.Text} - {datDatum.SelectedDate.Value.ToShortDateString()} - {cbTantargy.Text} - {Slidjegy.Value}");
        }
    }
}