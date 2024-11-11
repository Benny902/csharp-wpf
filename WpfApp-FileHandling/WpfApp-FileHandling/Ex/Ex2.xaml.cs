using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_FileHandling.Ex
{
    /// <summary>
    /// Interaction logic for Ex2.xaml
    /// </summary>
    public partial class Ex2 : UserControl
    {
        public Ex2()
        {
            InitializeComponent();
        }
        private void ReadFileButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "example.txt");

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                FileContentTextBlock.Text = content;
            }
            else
            {
                MessageBox.Show("File 'example.txt' not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
