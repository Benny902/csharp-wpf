using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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
    /// Interaction logic for Ex1.xaml
    /// </summary>
    public partial class Ex1 : UserControl
    {
        public Ex1()
        {
            InitializeComponent();
        }
        private void CreateFileButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "example.txt");
            string content = "Hello, World!";

            File.WriteAllText(filePath, content);

            MessageBox.Show($"File '{filePath}' created with content: '{content}'", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
