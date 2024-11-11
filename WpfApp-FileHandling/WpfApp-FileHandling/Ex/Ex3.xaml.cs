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
    /// Interaction logic for Ex3.xaml
    /// </summary>
    public partial class Ex3 : UserControl
    {
        public Ex3()
        {
            InitializeComponent();
        }
        private void WriteLinesButton_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = { "Line 1", "Line 2", "Line 3" };

            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "multilines.txt");

            File.WriteAllLines(filePath, lines);

            FileWriteStatusTextBlock.Text = "File 'multilines.txt' created successfully with multiple lines.";
        }
    }
}
