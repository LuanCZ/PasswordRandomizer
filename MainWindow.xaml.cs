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

namespace PasswordRandomizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PasswordRDM mdp;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnGenererMdp_Click(object sender, RoutedEventArgs e)
        {
            int iNbreMdp = 0;
            mdp = new PasswordRDM(cbMaj.IsChecked, cbSymb.IsChecked, cbChiffres.IsChecked);

            try
            {
                iNbreMdp = int.Parse(txtNbreMDP.Text);
            }
            catch
            {
                MessageBox.Show("La saisie est incorrect.");
            }

            if(iNbreMdp < 0)
            {
                MessageBox.Show("Le nombre de mot de passe doit être un nombre positif");
            }
            else if (iNbreMdp <= 1000)
            {
                txtMdp.Clear();
                for (int i = 0; i < iNbreMdp; i++)
                {
                    txtMdp.AppendText(mdp.GenererMdp() + "\n");
                }
            }
            else
            {
                MessageBox.Show("Le nombre de mot de passe est limité à 1000");
            }
           
            
            


        }
    }
}
