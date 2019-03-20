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

namespace fileWriteExample
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

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(txtFileName.Text);
                sw.WriteLine(txtInput.Text);
                sw.Flush();
                sw.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }

        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(txtFileName.Text, true);
                sw.WriteLine(txtInput.Text);
                sw.Flush();
                sw.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }
    }
}
