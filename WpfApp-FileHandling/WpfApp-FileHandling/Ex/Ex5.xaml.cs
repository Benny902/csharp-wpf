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
    /// Interaction logic for Ex5.xaml
    /// </summary>
    public partial class Ex5 : UserControl
    {
        public Ex5()
        {
            InitializeComponent();
        }
        private void CheckFileButton_Click(object sender, RoutedEventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "example.txt");

            if (System.IO.File.Exists(filePath))
            {
                string fileContent = System.IO.File.ReadAllText(filePath);
                FileContentTextBlock.Text = $"File Content:\n{fileContent}";
            }
            else
            {
                FileContentTextBlock.Text = "File does not exist.";
            }
        }
    }
}
