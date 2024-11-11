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
    /// Interaction logic for Ex2.xaml
    /// </summary>
    public partial class Ex2 : UserControl
    {
        public Ex2()
        {
            InitializeComponent();
        }
        private void MoveFileButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string sourceFilePath = System.IO.Path.Combine(projectDirectory, "fileToMove.txt");
            string targetFolderPath = System.IO.Path.Combine(projectDirectory, "TargetFolder");
            string targetFilePath = System.IO.Path.Combine(targetFolderPath, "fileToMove.txt");

            try
            {
                if (!Directory.Exists(targetFolderPath))
                {
                    Directory.CreateDirectory(targetFolderPath);
                }

                if (File.Exists(sourceFilePath))
                {
                    File.Move(sourceFilePath, targetFilePath);
                    MessageBox.Show("File moved successfully!");
                }
                else
                {
                    MessageBox.Show("Source file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
