using System;
using System.Collections.Generic;
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
    /// Interaction logic for Ex6.xaml
    /// </summary>
    public partial class Ex6 : UserControl
    {
        public Ex6()
        {
            InitializeComponent();
        }
        private void DeleteFileButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "example.txt");

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    System.IO.File.Delete(filePath);
                    StatusTextBlock.Text = "File deleted successfully.";
                }
                catch (Exception ex)
                {
                    StatusTextBlock.Text = $"Error deleting file: {ex.Message}";
                }
            }
            else
            {
                StatusTextBlock.Text = "File does not exist.";
            }
        }
    }
}
