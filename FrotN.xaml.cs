using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace encrytionapp
{
    /// <summary>
    /// Logique d'interaction pour FrotN.xaml
    /// </summary>
    public partial class FrotN : Window
    {
        public FrotN()
        {
            InitializeComponent();
            bool choice = Regexm(@"^[0 - 9]$| ^1[0 - 9] | ^2[0 -5]$", this.tbrotNSaisie);
            bool modulo = Regexm(@"([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){2,30}", this.tbrotN);

            if (modulo == true && choice == true)
            {

                string message = this.tbrotN.Text;
                MessageBox.Show("Le message chiffré : \n" + message);
            }
        }
        public bool Regexm(string re, TextBox tb)
        {
            bool valid = false;
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                return valid = true;
            }
            else
            {
                return valid;
            }
        }
    }
}
