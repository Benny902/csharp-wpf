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
    /// Interaction logic for Ex9.xaml
    /// </summary>
    public partial class Ex9 : UserControl
    {
        public Ex9()
        {
            InitializeComponent();
        }
        private void DeleteFolderButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string oldFolderPath = System.IO.Path.Combine(projectDirectory, "OldFolder");

            try
            {
                if (Directory.Exists(oldFolderPath))
                {
                    Directory.Delete(oldFolderPath, recursive: true);
                    MessageBox.Show("OldFolder and all its contents have been deleted.");
                }
                else
                {
                    MessageBox.Show("OldFolder does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
