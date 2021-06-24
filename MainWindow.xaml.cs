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
            mdp = new PasswordRDM();
        }

        private void btnGenererMdp_Click(object sender, RoutedEventArgs e)
        {
            txtMdp.Clear();
            for (int i = 0; i < 1000; i++)
            {
                txtMdp.AppendText(mdp.GenererMdp() + "\n");
            }
            
            


        }
    }
}
