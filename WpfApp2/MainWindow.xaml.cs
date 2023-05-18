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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Szakasz> elemek = new List<Szakasz>();
        List<string> kektura = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            Datagrid.ItemSource = kektura;
        }

    }
    private void adatokszama_Click(object sender, RoutedEventArgs e) {
        int adatokszama = elemek.Count();
        Messagebox.Show(${ adatokszama} +" darab adat van a listában.");
    }

    private void btnhosszSzam_Click(object sender, RoutedEventArgs e) {
        List<string> joElemek = new List<string>();
        try
        {
            hosszSzam.Content = "";
        }
        catch {
            Messagebox.Show("Adjon meg számot!")
        }
        for (int i = 0; i < elemek.Length; i++)
        {
            if (elemek[3] >= hosszSzam.Content) {
                joElemek.Add(elemek);
            }
        }
        MessageBox.Show(joElemek);
        mennyiVan.Content = joElemek.Count();
    }
    private void pilis_Click(object sender, RoutedEventArgs e)
    {
        List<string> pilis = new List<string>();
        for (int i = 0; i < elemek.Length; i++)
        {
            if (elemek.Contains("pilis") || elemek.Contains("Pilis")) {
                pilis.Add(elemek + "perc")
            }
        }
    }
    private void leghosszabb_Click(object sender, RoutedEventArgs e)
    {
        string leghosszabb = elemek.Max(elemek[1])
        MessageBox.Show(leghosszabb[0] leghosszabb[3]);
    }
    private void fajl_Click(object sender, RoutedEventArgs e)
    {
        File.WriteAllLines(kektura.txt, elemek)
    }
}
