using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2_DataBinding1.Ex
{
    /// <summary>
    /// Interaction logic for Ex2.xaml
    /// </summary>
    public partial class Ex2 : UserControl
    {
        private string _sharedText;
        public string SharedText
        {
            get => _sharedText;
            //set =>OnPropertyChanged(nameof(SharedText)); // for this we need the INotifyPropertyChanged interface or a manual event implement
            set => SetValue(SharedTextProperty, value);
        }

        public static readonly DependencyProperty SharedTextProperty =
            DependencyProperty.Register("SharedText", typeof(string), typeof(Ex2), new PropertyMetadata(string.Empty));

        public Ex2()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
