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

namespace fibonacciSeries
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

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int maxNumber = Convert.ToInt16(tbxMaxNumber.Text.Trim());
           

            int fibonacciCalculation = 0;

            //list of integers, is a dynamic array that we don't have to define a head of time

            List<int> fibonacciList = new List<int>;

            //defining the starting elements
            fibonacciList.Add(0);
            fibonacciList.Add(1);

            for (int arrayposition = 0; arrayposition <= maxNumber; arrayposition++)
            {
                int lastElement = fibonacciList[fibonacciList.Count - 1];
                int seconfLastElement = fibonacciList[fibonacciList.Count - 2];
                int result = lastElement + seconfLastElement;
                if (result <= maxNumber)
                {
                    fibonacciList.Insert(fibonacciList.Count, result)
                }
                fibonacciList.ElementAt(fibonacciList.Last<>)

            }
        }
    }
}
