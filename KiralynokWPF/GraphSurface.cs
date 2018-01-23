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
        public GraphSurface(StackPanel cont)
        {
            Label[,] lb = new Label[8, 8];
            StackPanel[] sp = new StackPanel[8];

            for (int i = 0; i < 8; i++)
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

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {

                    lb[i, j] = new Label
                    {
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Stretch,
                        FontSize = 20,
                        //Height = 50,
                        Width = 48,
                        Background = new SolidColorBrush(Colors.Aqua),
                        BorderBrush = new SolidColorBrush(Colors.Black),
                        Content = "#"

                    };
                    sp[i].Children.Add(lb[i, j]);
                }
            }
        }

    }
}

