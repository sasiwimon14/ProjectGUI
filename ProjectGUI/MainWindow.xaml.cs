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

namespace ProjectGUI
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

        private void btnCal_Click(object sender, RoutedEventArgs e)
        {
            double income = double.Parse(txtIncome.Text);
            double expenses = double.Parse(txtExpenses.Text);
            double price = double.Parse(txtPrice.Text);
            double saveDays = price / (income - expenses);
            txtDay.Text = saveDays.ToString();
        }
    }
}
