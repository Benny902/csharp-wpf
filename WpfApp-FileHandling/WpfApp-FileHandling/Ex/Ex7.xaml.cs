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
    /// Interaction logic for Ex7.xaml
    /// </summary>
    public partial class Ex7 : UserControl
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private int currentLineIndex = 0;
        private string[] lines;

        private void ReadFileButton_Click(object sender, RoutedEventArgs e)
        {
            //create
            string[] _lines = { "Line 1", "Line 2", "Line 3", "Line 4", "Line 5" };
            string _projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string _filePath = System.IO.Path.Combine(_projectDirectory, "sample.txt");
            File.WriteAllLines(_filePath, _lines);

            //read
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = System.IO.Path.Combine(projectDirectory, "sample.txt");

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    lines = System.IO.File.ReadAllLines(filePath);

                    if (currentLineIndex < lines.Length)
                    {
                        OutputTextBlock.Text = lines[currentLineIndex];
                        currentLineIndex++;
                    }
                    else
                    {
                        OutputTextBlock.Text = "No more lines to display.";
                    }
                }
                catch (Exception ex)
                {
                    OutputTextBlock.Text = $"Error reading file: {ex.Message}";
                }
            }
            else
            {
                OutputTextBlock.Text = "File does not exist.";
            }
        }
    }
}
