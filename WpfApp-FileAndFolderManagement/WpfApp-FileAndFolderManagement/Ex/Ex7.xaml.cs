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
    /// Interaction logic for Ex7.xaml
    /// </summary>
    public partial class Ex7 : UserControl
    {
        public Ex7()
        {
            InitializeComponent();
        }
        private void DeleteFilesButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current project directory
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            // Define the TempFolder path
            string tempFolderPath = System.IO.Path.Combine(projectDirectory, "TempFolder");

            try
            {
                // Check if the TempFolder exists
                if (Directory.Exists(tempFolderPath))
                {
                    // Get all files in the TempFolder
                    string[] files = Directory.GetFiles(tempFolderPath);

                    // Delete each file
                    foreach (string file in files)
                    {
                        File.Delete(file);
                        OutputTextBlock.Text += $"{System.IO.Path.GetFileName(file)} deleted.\n";
                    }

                    MessageBox.Show("All files in TempFolder have been deleted.");
                }
                else
                {
                    MessageBox.Show("TempFolder does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
