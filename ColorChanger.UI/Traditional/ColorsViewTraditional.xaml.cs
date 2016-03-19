using System;
using System.Collections.Generic;
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

namespace ColorChanger.UI.Traditional
{
    /// <summary>
    /// Interaction logic for ColorsViewTraditional.xaml
    /// </summary>
    public partial class ColorsViewTraditional : UserControl
    {
        public ColorsViewTraditional()
        {
            InitializeComponent();

            SliderRed.ValueChanged += SliderRed_OnValueChanged;
            SliderGreen.ValueChanged += SliderGreen_OnValueChanged;
            SliderBlue.ValueChanged += SliderBlue_OnValueChanged;

            InitColors();
        }

        private void SliderGreen_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void SliderRed_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void SliderBlue_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeColor();
        }

        private void InitColors()
        {
            Random r = new Random();
            SliderRed.Value = r.Next(byte.MinValue, byte.MaxValue);
            SliderGreen.Value = r.Next(byte.MinValue, byte.MaxValue);
            SliderBlue.Value = r.Next(byte.MinValue, byte.MaxValue);
        }

        private void ChangeColor()
        {
            var color = Color.FromArgb(255,
                (byte)SliderRed.Value,
                (byte)SliderGreen.Value,
                (byte)SliderBlue.Value);
            ColorRectangle.Fill = new SolidColorBrush(color);
        }
    }
}
