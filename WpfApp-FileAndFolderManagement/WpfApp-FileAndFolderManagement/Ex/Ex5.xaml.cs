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
    /// Interaction logic for Ex5.xaml
    /// </summary>
    public partial class Ex5 : UserControl
    {
        public Ex5()
        {
            InitializeComponent();
        }
        private void ListFilesButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string documentsFolderPath = System.IO.Path.Combine(projectDirectory, "Documents");

            try
            {
                if (Directory.Exists(documentsFolderPath))
                {
                    string[] files = Directory.GetFiles(documentsFolderPath);

                    OutputTextBlock.Text = "";

                    foreach (var file in files)
                    {
                        OutputTextBlock.Text += System.IO.Path.GetFileName(file) + "\n";
                    }
                }
                else
                {
                    MessageBox.Show("'Documents' folder does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
