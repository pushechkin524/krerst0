using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace xov1
{
    internal class Controls
    {
        public static string st;
        public static bool isx = true;
        public static void start()
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Button1.Content = "";
        }
        public static string xo(bool isx)
        {
            if (isx) st = "✕";
            else st = "◯";
            return st;
        }
        public static void bot(bool botnebot)
        {
            if (botnebot)
            {
                foreach (var track in ((MainWindow)System.Windows.Application.Current.MainWindow).xos.Children)
                {
                    if (track is Button && ((Button)track).Content == "")
                    {
                        ((Button)track).Content = xo(isx);
                        if (isx) ((Button)track).Foreground = Brushes.DarkRed;
                        if (!isx) ((Button)track).Foreground = Brushes.Blue;
                        break;
                    }
                }
            }
            else
            {
                if (Controls.isx) Controls.isx = false;
                else Controls.isx = true;
            }
        }
        public static void restart()
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Start.Content = "Restart";
            foreach (var track in ((MainWindow)System.Windows.Application.Current.MainWindow).xos.Children)
            {
                if (track is Button)
                {
                    ((Button)track).Content = "";
                    ((Button)track).Background = Brushes.Transparent;
                    ((Button)track).IsEnabled = true;
                }
            }
        }
    }
}
