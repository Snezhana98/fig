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


namespace fig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Figures> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Figures>();
        }
        
        private void OnClickBox(object sender, RoutedEventArgs e)
        {
            var box = new Box(canvas, double.Parse(coordX.Text), double.Parse(coordY.Text));
            list.Add(box);
        }

        private void OnClickCircle(object sender, RoutedEventArgs e)
        {
            var circle = new Circle(canvas, double.Parse(coordX.Text), double.Parse(coordY.Text));
            list.Add(circle);
        }

        private void OnClickFill(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SetColor();
            }
        }

        private void OnClickCoord(object sender, RoutedEventArgs e)
        {
            list.Last().Coord(double.Parse(coordX.Text), double.Parse(coordY.Text));
            
        }
    }
}
