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

namespace encrytionapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.btnGenererunmotpasse.Click += BtnGenererunmotpasse_Click;
            this.btnModulo.Click += BtnModulo_Click;
            this.btnRot13.Click += BtnRot13_Click;
            this.btnVigenre.Click += BtnVigenre_Click;
        }

        private void BtnVigenre_Click(object sender, RoutedEventArgs e)
        {
            Fvigenere fvigenere = new Fvigenere();
            fvigenere.Show();
        }

        private void BtnRot13_Click(object sender, RoutedEventArgs e)
        {
            
            FrotN frotN = new FrotN();
            frotN.Show();
        }

        private void BtnModulo_Click(object sender, RoutedEventArgs e)
        {
            Fmodulo modulo = new Fmodulo();
            modulo.Show();
        }

        private void BtnGenererunmotpasse_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le mot de passe généré : \n"+GenererMotDePasse());
        }

        private string GenererMotDePasse()
        {
            string mdp = "";
            char[] tab = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',  'S', 'T', 'U', 'V', 'W', 'X','Y', 'Z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','1','2','3','4','5','6','7','8','9','@',':','.','_','-','#','&','!','$','*'};
            Random aléatoire = new Random();
            Console.WriteLine(tab.Length);
            int choice = 0;
            for (int i = 0; i < 12; i++)
            {
               choice = aléatoire.Next(0, tab.Length);
               mdp = mdp + Convert.ToString(tab[choice]); 
            }
            return mdp;
        }
        
    }
}
