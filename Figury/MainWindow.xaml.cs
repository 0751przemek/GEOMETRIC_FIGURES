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

namespace Figury
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }     
        Rectangle rect = new Rectangle();
        Ellipse elip = new Ellipse();
        Polygon tri = new Polygon();
        Polygon tra = new Polygon();
        Point tr1 = new Point(158.5, 160.5);
        Point tr2 = new Point(248.5, 40.5);
        Point tr3 = new Point(340.5, 160.5);
        PointCollection PC = new PointCollection();
        PointCollection PC1 = new PointCollection();
        Point tra1 = new Point(176.5,159.5);
        Point tra2 = new Point(216.5,63.5);
        Point tra3 = new Point(278.5,63.5);
        Point tra4 = new Point(318.5,159.5);
        RotateTransform obrot = new RotateTransform();
        RotateTransform obrot1 = new RotateTransform();
        RotateTransform obrot2 = new RotateTransform();
        RotateTransform obrot3 = new RotateTransform();

        private void rysuj_Click(object sender, RoutedEventArgs e)
        {
            if (trojkat.IsChecked == true && tri.IsLoaded == false)
            {
                tri.Stroke = Brushes.Black;
                PC.Add(tr1);
                PC.Add(tr2);
                PC.Add(tr3);
                tri.Points = PC;
                tri.HorizontalAlignment = HorizontalAlignment.Center;
                tri.VerticalAlignment = VerticalAlignment.Center;
                tri.StrokeThickness = 3;
                pole.Children.Add(tri);
            }
            else if (trojkat.IsChecked == true && tri.IsLoaded == true)
            {  }
            else
            {
                pole.Children.Remove(tri);
            }
            if(kwadrat.IsChecked==true && rect.IsLoaded==false)
            {
                rect.Stroke = Brushes.Black;
                rect.Height = 120;
                rect.Width = 120;
                rect.HorizontalAlignment = HorizontalAlignment.Center;
                rect.VerticalAlignment = VerticalAlignment.Center;
                rect.StrokeThickness = 3;
                pole.Children.Add(rect);
                Canvas.SetRight(rect, 188.5);
                Canvas.SetTop(rect, 42.5);
            }
            else if (kwadrat.IsChecked == true && rect.IsLoaded == true)
            { }
            else
            {
                pole.Children.Remove(rect);
            }
            if(elipsa.IsChecked==true && elip.IsLoaded==false)
            {
                elip.Stroke = Brushes.Black;
                elip.Height = 160;
                elip.Width = 160;
                elip.HorizontalAlignment = HorizontalAlignment.Center;
                elip.VerticalAlignment = VerticalAlignment.Center;
                elip.StrokeThickness = 3;
                pole.Children.Add(elip);
                Canvas.SetRight(elip,168.5);
                Canvas.SetTop(elip, 52.5);
            }
            else if (elipsa.IsChecked == true && elip.IsLoaded == true)
            { }
            else
            {
                pole.Children.Remove(elip);
            }
               if(trapez.IsChecked==true && tra.IsLoaded==false)
            {
                tra.Stroke = Brushes.Black;
                PC1.Add(tra1);
                PC1.Add(tra2);
                PC1.Add(tra3);
                PC1.Add(tra4);
                tra.Points = PC1;
                tra.HorizontalAlignment = HorizontalAlignment.Center;
                tra.VerticalAlignment = VerticalAlignment.Center;
                tra.StrokeThickness = 3;
                pole.Children.Add(tra);
            }
            else if (trapez.IsChecked == true && tra.IsLoaded == true)
               { }
            else 
            {
                pole.Children.Remove(tra);
            }   
       
        }

        private void Kasuj_Click(object sender, RoutedEventArgs e)
        {

            pole.Children.Remove(tri);
            pole.Children.Remove(rect);
            pole.Children.Remove(elip);
            pole.Children.Remove(tra);

        }
    }
}
