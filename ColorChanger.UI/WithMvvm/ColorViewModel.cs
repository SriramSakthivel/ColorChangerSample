using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace ColorChanger.UI.WithMvvm
{
    public class ColorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private byte red;
        private byte green;
        private byte blue;
        public byte Alpha
        {
            get { return byte.MaxValue; }
        }

        public byte Red
        {
            get { return red; }
            set
            {
                red = value;
                OnPropertyChanged();
                OnPropertyChanged("Color");
            }
        }

        public byte Green
        {
            get { return green; }
            set
            {
                green = value;
                OnPropertyChanged();
                OnPropertyChanged("Color");
            }
        }

        public byte Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                OnPropertyChanged();
                OnPropertyChanged("Color");
            }
        }

        public Color Color 
        {
            get
            {
                return Color.FromArgb(Alpha,Red, Green, Blue);
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
