using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Hastigheds_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, double> units = new Dictionary<string, double>()
        {
            {"m/s", 1.0},{}
        };
        bool changed = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private double Calulate(int input, double from, double to)
        {
            double factor = to * from;
            return input * factor;
        }

        private void TextLeft_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = TextLeft.Text;
            if (text == "")
            {

            }
            else if (changed == false)
            {
                int input = Convert.ToInt32(text);

            }
            else
            {
                changed = false;
            }
        }

        private void TextRight_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            e.Handled = !AreAllValidNumericChars(e.Text);
            base.OnPreviewTextInput(e);
        }

        private bool AreAllValidNumericChars(string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                {
                    return false;
                }
            }

            return true;
        }

        private void TextLeft_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            OnPreviewTextInput(e);
        }

        private void TextRight_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            OnPreviewTextInput(e);
        }
    }
}
