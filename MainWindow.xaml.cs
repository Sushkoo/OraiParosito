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

namespace WpfApp2
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

        private void ferfibeiro_TextChanged(object sender, TextChangedEventArgs e)
        {

                      
        }

        private void nobeiro_TextChanged(object sender, TextChangedEventArgs e)
        {
                
            
        }

        private void mixbtn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            List<object> itemsList1 = ferfiak.Items.Cast<object>().ToList();
            List<object> itemsList2 = nok.Items.Cast<object>().ToList();


            ferfiak.Items.Clear();
            nok.Items.Clear();


            while (itemsList1.Count > 0 && itemsList2.Count > 0)
            {
                int index1 = random.Next(itemsList1.Count);
                int index2 = random.Next(itemsList2.Count);

                kiiras.Items.Add($"{itemsList1[index1]} -- {itemsList2[index2]}");


                itemsList1.RemoveAt(index1);
                itemsList2.RemoveAt(index2);
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = ferfibeiro.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                ferfiak.Items.Add(text);
                ferfibeiro.Clear();
            }

            string textNo = nobeiro.Text.Trim();
            if (!string.IsNullOrEmpty(textNo))
            {
                nok.Items.Add(textNo);
                nobeiro.Clear();
            }
        }
    }
}

