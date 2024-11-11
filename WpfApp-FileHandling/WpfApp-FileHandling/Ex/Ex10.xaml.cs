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
    /// Interaction logic for Ex10.xaml
    /// </summary>
    public partial class Ex10 : UserControl
    {
        public Ex10()
        {
            InitializeComponent();
        }
        private void CopyAndMoveFileButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string originalFilePath = System.IO.Path.Combine(projectDirectory, "original.txt");
            string copyFilePath = System.IO.Path.Combine(projectDirectory, "copy.txt");

            string movedFolderPath = System.IO.Path.Combine(projectDirectory, "movedFolder");
            string movedFilePath = System.IO.Path.Combine(movedFolderPath, "moved.txt");

            try
            {
                // Create the original file with sample text if it doesn't exist
                if (!File.Exists(originalFilePath))
                {
                    File.WriteAllText(originalFilePath, "This is a sample text in the original file.");
                    MessageBox.Show($"Original file created at {originalFilePath}.", "File Created", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                // Copy original.txt to copy.txt if the original file exists
                if (File.Exists(originalFilePath))
                {
                    File.Copy(originalFilePath, copyFilePath, overwrite: true);  // Overwrite if copy.txt already exists
                    MessageBox.Show($"File copied from {originalFilePath} to {copyFilePath}.", "File Copied", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                // make sure the folder exists before moving the file, create if not, and Move copy.txt to the moved folder and rename it to moved.txt
                if (!Directory.Exists(movedFolderPath))
                {
                    Directory.CreateDirectory(movedFolderPath);
                    MessageBox.Show($"Folder created at {movedFolderPath}.", "Folder Created", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (File.Exists(copyFilePath))
                {
                    File.Move(copyFilePath, movedFilePath);
                    MessageBox.Show($"File moved and renamed to {movedFilePath}.", "File Moved", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                // Check if the move was successful
                if (File.Exists(movedFilePath))
                {
                    MessageBox.Show($"The file has been successfully moved and renamed to {movedFilePath}.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error: File could not be moved.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
