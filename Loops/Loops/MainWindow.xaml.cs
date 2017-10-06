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

namespace Loops
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int answer = Convert.ToInt16(tbxScore.Text.Trim());

                if (answer >= 90 && answer <100)
                {
                    MessageBox.Show("You Got an A");
                }
                else if (answer >= 80)
                {
                    MessageBox.Show("You Got an B");
                }
                else if (answer >= 70)
                {
                    MessageBox.Show("You Got an C");
                }
                else if (answer >= 60)
                {
                    MessageBox.Show("You Got an D");
                }
                else (answer < 60)
                {
                    MessageBox.Show("You Got an F");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("There is a problem with your number");
            }
            
        }
    }
}
