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

namespace TestesWpf
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

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");

            if (this.c1.IsChecked == true)
                MessageBox.Show("ok1");
            else
                MessageBox.Show("ok2");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cmb = (ComboBox)sender;

            var itemSelected = ((ComboBoxItem)cmb.SelectedItem).Content;

            MessageBox.Show(itemSelected.ToString());
        }

        private void c3_Checked(object sender, RoutedEventArgs e)
        {
            var check = (CheckBox)sender;

            if (check.IsChecked == true)
                MessageBox.Show("check");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("init");
        }

        private void txtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTest.Text = txtDescription.Text;
        }
    }
}
