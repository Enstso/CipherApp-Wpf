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
    /// Logique d'interaction pour Fvigenere.xaml
    /// </summary>
    public partial class Fvigenere : Window
    {
        public Fvigenere()
        {
            InitializeComponent();
            this.rbChiffrer.Checked += RbChiffrer_Checked; ;
            this.rbDechiffrer.Checked += RbDechiffrer_Checked; ;
            this.btnValider.Click += BtnValider_Click; ;
            this.rbChiffrer.IsChecked = true;

        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            bool saisie = Regexm(@"([a-zA-Z',.-]+( [a-zA-Z',.-]+)*){1,30}", this.tbVigenere);
            int choice = RadioChoice();
            string maSaisie = RemoveLastLinetb(this.tbVigenere.Text);
            string message = "";
            switch (choice)
            {
                case 0:

                    if (saisie == true)
                    {

                        message = messageChiffré(maSaisie);
                        MessageBox.Show("Le message chiffré : \n" + message, "Message");
                    }
                    else
                    {
                        if (maSaisie != "")
                        {
                            MessageBox.Show("Des caractères non valides ont été détecté, seul les lettres sont acceptées", "Attention");
                        }
                    }

                    break;
                case 1:
                    if (saisie == true)
                    {

                        message = messageDéchiffré(maSaisie);
                        MessageBox.Show("Le message Déchiffré : \n" + message,"Message");
                    }
                    else
                    {
                        if (maSaisie != "")
                        {
                            MessageBox.Show("Des caractères non valides ont été détecté, seul les lettres sont acceptées","Attention");
                        }
                    }
                    break;
                default:
                    break;
            }
            this.tbVigenere.Text = "";

        }

        private void RbDechiffrer_Checked(object sender, RoutedEventArgs e)
        {
            if (rbChiffrer.IsChecked == true)
            {
                this.rbChiffrer.IsChecked = false;
            }
        }

        private void RbChiffrer_Checked(object sender, RoutedEventArgs e)
        {
            if (rbDechiffrer.IsChecked == true)
            {
                rbDechiffrer.IsChecked = false;
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

        public string messageChiffré(string tbmessage)
        {
            char[] tabMaj = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] tabMin = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string message = "";
            char tempo;
            int positionchiff = 0;
            int[] key = Key(tbmessage.Length);
            for (int i = 0; i < tbmessage.Length; i++)
            {

                if (IsCharUppercaseOrLowercase(tbmessage[i]) == "maj")
                {
                    int positionMaj = GetCharPositionInAlphabetMaj(tbmessage[i]);
                    if (positionMaj + key[i] > 25)
                    {
                        positionchiff = key[i] - (25 - (positionMaj - 1));
                        tempo = tabMaj[positionchiff];
                    }
                    else
                    {
                        positionchiff = positionMaj + key[i];
                        tempo = tabMaj[positionchiff];
                    }
                }
                else
                {
                    int positionMin = GetCharPositionInAlphabetMin(tbmessage[i]);
                    if (positionMin + key[i] > 25)
                    {
                        positionchiff = key[i] - (25 - (positionMin - 1));
                        tempo = tabMaj[positionchiff];
                    }
                    else
                    {
                        positionchiff = positionMin + key[i];
                        tempo = tabMin[positionchiff];
                    }

                }

                message = message + tempo;
            }
            return message;
        }

        public string messageDéchiffré(string tbmessage)
        {
            char[] tabMaj = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] tabMin = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string message = "";
            char tempo;
            int positionchiff = 0;
            int[] key = Key(tbmessage.Length);
            for (int i = 0; i < tbmessage.Length; i++)
            {
                int positionMaj = GetCharPositionInAlphabetMaj(tbmessage[i]);

                if (IsCharUppercaseOrLowercase(tbmessage[i]) == "maj")
                {
                    if (positionMaj - key[i] < 0)
                    {
                        positionchiff = 25 - (key[i] - (positionMaj + 1));
                        tempo = tabMaj[positionchiff];
                    }
                    else
                    {

                        positionchiff = positionMaj - key[i];
                        tempo = tabMaj[positionchiff];
                    }
                }
                else
                {
                    int positionMin = GetCharPositionInAlphabetMin(tbmessage[i]);
                    if (positionMin - key[i] < 0)
                    {
                        positionchiff = 25 - (key[i] - (positionMin + 1));
                        tempo = tabMin[positionchiff];
                    }
                    else
                    {

                        positionchiff = positionMin - key[i];
                        tempo = tabMin[positionchiff];
                    }

                }

                message = message + tempo;
            }
            return message;
        }

        public int GetCharPositionInAlphabetMin(char c)
        {

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int index = Array.IndexOf(alphabet, c);
            if (index == -1)
            {
                return -1;
            }

            else
            {
                return index;
            }
        }

        public int GetCharPositionInAlphabetMaj(char c)
        {
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int index = Array.IndexOf(alphabet, c);

            if (index == -1)
            {
                return -1;
            }

            else
            {
                return index;
            }
        }


        public string IsCharUppercaseOrLowercase(char c)
        {

            if (Char.IsUpper(c) == true)
            {
                return "maj";
            }
            else
            {
                return "min";
            }
        }

        public int RadioChoice()
        {
            int choice = 0;
            if (this.rbChiffrer.IsChecked == true)
            {
                return choice;
            }
            else
            {
                if (rbDechiffrer.IsChecked == true)
                {
                    return choice = 1;
                }
            }
            return choice;

        }



        public string RemoveLastLinetb(string str)
        {
            List<string> List = str.Split().ToList();
            List.Remove("");
            List.Remove("");
            List.Remove("");
            if (List.Count == 0)
            {
                MessageBox.Show("Saisissez un message","Attetion");
                return "";
            }
            else
            {
                return List[0];
            }
        }

        public int[] Key(int pas)
        {

            int compteur2 = 0;
            char[] code = new char[] { 'D', 'C', 'O', 'D', 'E' };
            char[] key = new char[pas];
            int[] keyPosition = new int[pas];

            for (int i = 0; i < pas; i++)
            {

                key[i] = code[compteur2];

                if (code[compteur2] == 'E')
                {
                    compteur2 = 0;
                }
                else
                {
                    compteur2++;
                }
            }

            for (int i = 0; i < key.Length; i++)
            {
                keyPosition[i] = GetCharPositionInAlphabetMaj(key[i]);
            }
            return keyPosition;
        }
    }
}

