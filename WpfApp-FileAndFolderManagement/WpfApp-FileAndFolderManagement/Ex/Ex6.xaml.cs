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
    /// Interaction logic for Ex6.xaml
    /// </summary>
    public partial class Ex6 : UserControl
    {
        public Ex6()
        {
            InitializeComponent();
        }
        private void CopyFilesButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string sourceFolderPath = System.IO.Path.Combine(projectDirectory, "SourceFolder");
            string destinationFolderPath = System.IO.Path.Combine(projectDirectory, "DestinationFolder");

            try
            {
                if (Directory.Exists(sourceFolderPath))
                {
                    if (!Directory.Exists(destinationFolderPath))
                    {
                        Directory.CreateDirectory(destinationFolderPath);
                    }

                    string[] files = Directory.GetFiles(sourceFolderPath);

                    OutputTextBlock.Text = "Copying files...\n";

                    foreach (var file in files)
                    {
                        string fileName = System.IO.Path.GetFileName(file);
                        string destinationFilePath = System.IO.Path.Combine(destinationFolderPath, fileName);

                        File.Copy(file, destinationFilePath, overwrite: true); // overwrite = true allows overwriting existing files

                        OutputTextBlock.Text += $"{fileName} copied successfully.\n";
                    }

                    MessageBox.Show("Files copied successfully!");
                }
                else
                {
                    MessageBox.Show("Source folder does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
