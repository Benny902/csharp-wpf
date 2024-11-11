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
    /// Interaction logic for Ex8.xaml
    /// </summary>
    public partial class Ex8 : UserControl
    {
        public Ex8()
        {
            InitializeComponent();
        }
        private void WriteBinaryDataButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "binaryfile.dat");

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (BinaryWriter writer = new BinaryWriter(fs))
                    {
                        writer.Write(12345);

                        writer.Write("Hello, this is a binary file!");
                    }
                }
                MessageBox.Show($"Binary data written to {filePath}", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
