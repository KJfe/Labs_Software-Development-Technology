using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace View
{
    class test:Page
    {
        public void CreateEllipse()
        {
            //Create a StackPanel to contain the shape.
            StackPanel myStackPanel = new StackPanel();

            //Create a red Ellipse.
            Ellipse myEllipse = new Ellipse();

            //Create a SolidColorBrush with a red color to fill the
            // Ellipse with.
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values. 
            // Each value has a range of 0-255.
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            myEllipse.Fill = mySolidColorBrush;
            myEllipse.StrokeThickness = 2;
            myEllipse.Stroke = Brushes.Black;

            // Set the width and height of the Ellipse.
            myEllipse.Width = 200;
            myEllipse.Height = 100;

            // Add the Ellipse to the StackPanel.
            myStackPanel.Children.Add(myEllipse);

            this.Content = myStackPanel;
        }

        public void CreateLine()
        {
            // Add a Line Element
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = 1;
            myLine.X2 = 50;
            myLine.Y1 = 1;
            myLine.Y2 = 50;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            //myGrid.Children.Add(myLine);
        }
    }
}
