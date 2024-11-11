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

namespace WpfApp_FileAndFolderManagement.Ex
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
        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string sourceFilePath = System.IO.Path.Combine(projectDirectory, "source.txt");
            string destinationFilePath = System.IO.Path.Combine(projectDirectory, "destination.txt");

            try
            {
                if (!File.Exists(sourceFilePath))
                {
                    File.WriteAllText(sourceFilePath, "This is the source file content.");
                    StatusTextBlock.Text = "Source file created with sample content.";
                }

                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
                    StatusTextBlock.Text = $"File copied to {destinationFilePath}.";
                }
            }
            catch (Exception ex)
            {
                StatusTextBlock.Text = $"Error: {ex.Message}";
            }
        }
    }
}
