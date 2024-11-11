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
    /// Interaction logic for Ex10.xaml
    /// </summary>
    public partial class Ex10 : UserControl
    {
        public Ex10()
        {
            InitializeComponent();
        }
        private void MoveFolderButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string sourceFolderPath = System.IO.Path.Combine(projectDirectory, "MoveThisFolder");
            string destinationFolderPath = System.IO.Path.Combine(projectDirectory, "NewLocation", "MoveThisFolder");

            try
            {
                if (Directory.Exists(sourceFolderPath))
                {
                    string destinationDirectory = System.IO.Path.GetDirectoryName(destinationFolderPath);
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    Directory.Move(sourceFolderPath, destinationFolderPath);
                    MessageBox.Show($"Folder 'MoveThisFolder' has been moved to {destinationFolderPath}.");
                }
                else
                {
                    MessageBox.Show("Source folder 'MoveThisFolder' does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
