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
    /// Interaction logic for Ex6b.xaml
    /// </summary>
    public partial class Ex6b : UserControl
    {
        public Ex6b()
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

                    CopyDirectory(sourceFolderPath, destinationFolderPath);

                    MessageBox.Show("Files and folders copied successfully!");
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

        private void CopyDirectory(string sourceDir, string destDir)
        {
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = System.IO.Path.Combine(destDir, System.IO.Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);
                OutputTextBlock.Text += $"{System.IO.Path.GetFileName(file)} copied.\n";
            }

            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string subDirName = System.IO.Path.GetFileName(subDir);
                string newDestDir = System.IO.Path.Combine(destDir, subDirName);

                if (!Directory.Exists(newDestDir))
                {
                    Directory.CreateDirectory(newDestDir);
                }

                CopyDirectory(subDir, newDestDir);
            }
        }
    }
}
