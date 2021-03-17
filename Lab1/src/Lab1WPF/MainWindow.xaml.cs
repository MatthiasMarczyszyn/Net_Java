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
using Lab1;

namespace Lab1WPF
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            var capacity = 0;
            var ammount = 0;
            capacity = Int32.Parse(bagCapacity.Text);
            ammount = Int32.Parse(itemsAmount.Text);
            RandomNumberGenerator rng = new RandomNumberGenerator(19);
            List<int> itemList = new List<int>();
            List<int> valueList = new List<int>();
            List<int> weightList = new List<int>();
            for (var i = 0; i < ammount; i++) itemList.Add(i);
            foreach (var item in itemList)
            {
                valueList.Add(rng.nextInt(1, 29));
                weightList.Add(rng.nextInt(1, 29));
            }
            MessageBox.Show(Program.KnapsackProblemNaive(capacity,itemList,valueList,weightList).ToString());
        }
    }
}
