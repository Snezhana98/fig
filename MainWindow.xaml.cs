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

        private void OnClickRectangle(object sender, RoutedEventArgs e)
        {
            var pryamoygolnik = new Pryamoygolnik(canvas, double.Parse(coordX.Text), double.Parse(coordY.Text));
            list.Add(pryamoygolnik);
        }

        private void OnClickEllipse(object sender, RoutedEventArgs e)
        {
            var oval = new Oval(canvas, double.Parse(coordX.Text), double.Parse(coordY.Text));
            list.Add(oval);
        }

        private void OnClickStar(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickPicture(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickLeft(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickRight(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickUp(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickDown(object sender, RoutedEventArgs e)
        {

        }


        private void OnClickBefore(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickNext(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickSizes(object sender, RoutedEventArgs e)
        {
            list.Last().Sizes(double.Parse(TextHeigth.Text), double.Parse(TextWidth.Text));
        }
    }
}
