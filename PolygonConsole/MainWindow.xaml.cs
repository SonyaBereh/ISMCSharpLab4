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

namespace PolygonConsole
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static double x, y, x1, y1, x0, y0, sum1 = 0, sum2 = 0, res = 0;
        static int n = 1;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lb1.Content = ("X" + (n + 1) + "=");
            lb2.Content = ("Y" + (n + 1) + "=");
            if (n > 1)
            {
                x1 = x;  
                y1 = y;
            }


            x = Convert.ToDouble(tb1.Text);
            y = Convert.ToDouble(tb2.Text);
            if (n == 1)
            {
                x0 = x;             
                y0 = y;
            }


            sum1 += y1 * x;     
            if (n >= 3)
            {
                res = Math.Abs(((sum1 + x0 * y) - (sum2 + y0 * x)) / 2);  
                lb3.Content = ("Площадь " + n.ToString() + "-угольника = " + res.ToString()); 
            }
            tb1.Text = (""); 
            tb2.Text = ("");


            n++; 
        }
    }
}
