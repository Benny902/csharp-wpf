using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
    /// Interaction logic for Ex6.xaml
    /// </summary>
    /// 

    public class AgeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (int.TryParse(value.ToString(), out int age))
            {
                if (age >= 0 && age <= 120)
                    return ValidationResult.ValidResult;
                else
                    return new ValidationResult(false, "Age must be between 0 and 120.");
            }
            return new ValidationResult(false, "Please enter a valid number.");
        }
    }

    public partial class Ex6 : UserControl
    {
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public Ex6()
        {
            InitializeComponent();
            DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
