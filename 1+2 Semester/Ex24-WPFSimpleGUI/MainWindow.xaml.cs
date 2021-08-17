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

namespace Ex24_WPFSimpleGUI
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

        // Scroll up
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string temp = textbox1.Text;
            string temp2 = textbox2.Text;

            textbox1.Text = temp2;
            temp2 = textbox3.Text;
            textbox2.Text = temp2;
            temp2 = textbox4.Text;
            textbox3.Text = temp2;
            textbox4.Text = temp;
        }

        // Clear
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
        }

        // Scroll down
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string text1 = textbox1.Text;
            string text2 = textbox2.Text;
            string text3 = textbox3.Text;
            string text4 = textbox4.Text;

            textbox1.Text = text4;
            textbox2.Text = text1;
            textbox3.Text = text2;
            textbox4.Text = text3;
        }
    }
}
