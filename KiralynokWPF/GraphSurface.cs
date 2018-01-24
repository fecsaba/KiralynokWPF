using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KiralynokWPF
{
    public partial class GraphSurface 
    {
        public Label[,] Lb;

       
        
        public GraphSurface(StackPanel cont, int r, int c)
        {
            Label[,] lb = new Label[r, c];
            Lb = lb;
            StackPanel[] sp = new StackPanel[r];

            for (int i = 0; i < r; i++)
            {
                sp[i] = new StackPanel
                {
                    Background = new SolidColorBrush(Colors.Beige),
                    //Height = 40,
                    //Width = 350,
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment=HorizontalAlignment.Stretch,
                    VerticalAlignment=VerticalAlignment.Stretch


                };
                cont.Children.Add(sp[i]);
            }

            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < c; j++)
                {

                    lb[i, j] = new Label
                    {
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Stretch,
                        FontSize = 20,
                        //Height = 50,
                        Width = 48,
                        Background = new SolidColorBrush(Colors.BlanchedAlmond),
                        BorderBrush = new SolidColorBrush(Colors.Black),
                        Content = "#",
                        BorderThickness = new Thickness(.5,.5,.5,.5)

                    };
                    sp[i].Children.Add(lb[i, j]);
                }
            }

        }

    }
}

