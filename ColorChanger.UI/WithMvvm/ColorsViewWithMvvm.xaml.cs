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

namespace ColorChanger.UI.WithMvvm
{
    /// <summary>
    /// Interaction logic for ColorsViewWithMvvm.xaml
    /// </summary>
    public partial class ColorsViewWithMvvm : UserControl
    {
        public ColorsViewWithMvvm()
        {
            InitializeComponent();

            var viewModel = CreateColorViewModel();
            this.DataContext = viewModel;
        }

        private ColorViewModel CreateColorViewModel()
        {
            Random r = new Random();
            return new ColorViewModel()
            {
                Red = (byte)r.Next(byte.MinValue, byte.MaxValue),
                Green = (byte)r.Next(byte.MinValue, byte.MaxValue),
                Blue = (byte)r.Next(byte.MinValue, byte.MaxValue),
            };
        }
    }
}
