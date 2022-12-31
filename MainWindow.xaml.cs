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
            throw new NotImplementedException();
        }

        private void BtnRot13_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnModulo_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnGenererunmotpasse_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le mot de passe généré \n");
        }

        
    }
}
