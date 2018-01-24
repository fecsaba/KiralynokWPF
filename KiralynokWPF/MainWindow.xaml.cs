using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace KiralynokWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GraphSurface Gs;
        Tábla Tbl;
        int row = 5;
        int col = 5;
        char üc = '#';
        public MainWindow()
        {

            InitializeComponent();
            
            
            
            GraphSurface gs = new GraphSurface(Container, row, col);
            Gs = gs;
            Tábla tbl = new Tábla(üc, row, col);
            Tbl = tbl;
            
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int db = 8;
            Tbl.Elhelyez(db, Gs);
            UO.Content = $"Üres oszlop: {Tbl.UresOszlopokSzama}";
            US.Content = $"Üres sor: {Tbl.UresSorokSzama}";
            Btn.Visibility = Visibility.Visible;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            const string fájlNeve = "tablak64.txt";
           
            if (File.Exists(fájlNeve)) File.Delete(fájlNeve);
            StreamWriter sw = new StreamWriter(fájlNeve);
            
            for (int i = 0; i < row*col+1; i++)
            {
                üc = '*';
                Tábla aktTábla = new Tábla(üc, row, col);
                aktTábla.Elhelyez(i, Gs);
                
                aktTábla.FajlbaIr(sw);
            }
            sw.Close();
        }
    }
}
