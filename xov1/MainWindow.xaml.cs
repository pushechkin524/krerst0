using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace xov1
{
    public partial class MainWindow : Window
    {
        public static bool botenabled;
        public MainWindow()
        {
            
            InitializeComponent();
            foreach (var track in xos.Children)
            {
                if (track is Button)
                {
                    ((Button)track).Content = "";
                    ((Button)track).Background = Brushes.Gray;
                    
                    ((Button)track).IsEnabled = false;
                }
            }


        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content == "")
            {
                string input = Controls.xo(!Controls.isx);
                ((Button)sender).Content = input;
                if (Controls.isx) ((Button)sender).Foreground = Brushes.Blue;
                if (!Controls.isx) ((Button)sender).Foreground = Brushes.DarkRed;
                Controls.bot(botenabled);
                stop();
            }
        }

        private void stop()
        {
            
            if ((Button1.Content == "✕" && Button2.Content == "✕" && Button3.Content == "✕") || (Button4.Content == "✕" && Button5.Content == "✕" && Button6.Content == "✕") ||  (Button7.Content == "✕" && Button8.Content == "✕" && Button9.Content == "✕") ||  (Button1.Content == "✕" && Button5.Content == "✕" && Button9.Content == "✕") ||  (Button1.Content == "✕" && Button4.Content == "✕" && Button7.Content == "✕") ||  (Button2.Content == "✕" && Button5.Content == "✕" && Button8.Content == "✕") ||
               (Button3.Content == "✕" && Button6.Content == "✕" && Button9.Content == "✕") ||(Button3.Content == "✕" && Button5.Content == "✕" && Button7.Content == "✕"))
            {
                foreach (var button in xos.Children)
                {
                    if (button is Button)
                    {

                        ((Button)button).IsEnabled = false;
                    }
                }
                WinnerOutput.Content = "Нолик в ахуе";
            }

            if ((Button1.Content == "◯" && Button2.Content == "◯" && Button3.Content == "◯") || (Button4.Content == "◯" && Button5.Content == "◯" && Button6.Content == "◯") ||  (Button7.Content == "◯" && Button8.Content == "◯" && Button9.Content == "◯") ||  (Button1.Content == "◯" && Button5.Content == "◯" && Button9.Content == "◯") ||  (Button1.Content == "◯" && Button4.Content == "◯" && Button7.Content == "◯") ||  (Button2.Content == "◯" && Button5.Content == "◯" && Button8.Content == "◯") ||
               (Button3.Content == "◯" && Button6.Content == "◯" && Button9.Content == "◯") ||(Button3.Content == "◯" && Button5.Content == "◯" && Button7.Content == "◯"))
            {
                foreach (var button in xos.Children)
                {
                    if (button is Button)
                    {

                        ((Button)button).IsEnabled = false;
                    }
                }
                WinnerOutput.Content = "Крестик в ахуе";
            }
            if ((Button1.Content != "" && Button2.Content != "" && Button3.Content != "" && Button4.Content != "" && Button5.Content != "" && Button6.Content != "" && Button7.Content != "" && Button8.Content != "" && Button9.Content != ""))
            {
                foreach (var track in xos.Children)
                {
                    if (track is Button)
                    {

                        ((Button)track).IsEnabled = false;
                    }
                }
                WinnerOutput.Content = "Ни дать ни взять блять";
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Controls.restart();
            WinnerOutput.Content = "";
            if (Controls.isx) Controls.isx = false;
            else Controls.isx = true;
        }

        private void botenabling(object sender, RoutedEventArgs e)
        {
            if (botenabled)
            {
                botenabled = false;
                Bot.Background = Brushes.DarkGray;
            }
            else
            {
                botenabled = true;
                Bot.Background = Brushes.DarkGreen;
                
            }
            Controls.restart();

        }
    }
}
