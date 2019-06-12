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
using System.Windows.Threading;

namespace SolidColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ColorHandler colorController = new ColorHandler();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SliderForR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            colorArea.Fill = colorController.SliderColor(Convert.ToByte(sliderForB.Value), Convert.ToByte(sliderForG.Value), Convert.ToByte(sliderForR.Value));
            colorPickHex.Text = colorController.RGBtoHex(Convert.ToByte(sliderForB.Value), Convert.ToByte(sliderForG.Value), Convert.ToByte(sliderForR.Value));
        }

        private void SliderForG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            colorArea.Fill = colorController.SliderColor(Convert.ToByte(sliderForB.Value), Convert.ToByte(sliderForG.Value), Convert.ToByte(sliderForR.Value));
            colorPickHex.Text = colorController.RGBtoHex(Convert.ToByte(sliderForB.Value), Convert.ToByte(sliderForG.Value), Convert.ToByte(sliderForR.Value));
        }

        private void SliderForB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            colorArea.Fill = colorController.SliderColor(Convert.ToByte(sliderForB.Value), Convert.ToByte(sliderForG.Value), Convert.ToByte(sliderForR.Value));
            colorPickHex.Text = colorController.RGBtoHex(Convert.ToByte(sliderForB.Value), Convert.ToByte(sliderForG.Value), Convert.ToByte(sliderForR.Value));
        }
    }
}
