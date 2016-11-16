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

namespace NombreMystereWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string wrongInput = "Oups, saisie incorrecte... C'est à toi : ";
        string messSup = "Plus grand";
        string messInf = "Plus petit";
        string messWin = "Bravo, tu as trouvé en ";
        int iterator;
        int num;
        int inputOut;
        bool verify = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            newGame();
        }

        private void mw_bt_valid_Click(object sender, RoutedEventArgs e)
        {
            iterator++;
            updateTries();
            mw_tbk_result.Text = string.Empty;
            string input = mw_tbx_input.Text;
            if (verifyInput(input) != false )
            {
                if (num != inputOut)
                {
                    test(inputOut);
                }
                else
                {
                    youWin();
                }
            }
        }

        private void mw_bt_newGame_Click(object sender, RoutedEventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            num = new Random().Next(0, 20);
            mw_tbk_result.Text = string.Empty;
            mw_tbx_input.Text = string.Empty;
            iterator = 0;
            updateTries();
        }

        private bool verifyInput(string input)
        {
            if (int.TryParse(input, out inputOut) == false || inputOut > 20 || inputOut < 0)
            {
                verify = false;
                mw_tbk_result.Text = wrongInput;
            }
            return verify;
        }

        private void test(int inputOut)
        {
            if (num < inputOut)
            {
                mw_tbk_result.Text = messInf;
            }
            else
            {
                mw_tbk_result.Text = messSup;
            }
        }

        private void youWin()
        {
            mw_tbk_result.Text = messWin + iterator + " coups";
        }

        private void updateTries()
        {
            mw_tbx_tries.Text = "Nombre d'essais : " + iterator;
        }
    }
}
