using System;
using System.Media;
using System.Windows;
using System.Windows.Media;

namespace Soundboard
{
    public partial class MainWindow : Window
    {
        private bool isDarkMode;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleMode_Checked(object sender, RoutedEventArgs e)
        {
            isDarkMode = true;
            UpdateTheme();
        }

        private void ToggleMode_Unchecked(object sender, RoutedEventArgs e)
        {
            isDarkMode = false;
            UpdateTheme();
        }

        private void UpdateTheme()
        {
            if (isDarkMode)
            {
                grdPozadi.Background = Brushes.White;
                ToggleMode.Foreground = Brushes.Black;
            }
            else
            {
                grdPozadi.Background = Brushes.Black;
                ToggleMode.Foreground = Brushes.White;
            }
        }

        private void PlaySound(string soundFile)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(soundFile))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string soundFile = "./audio/1.wav";
            PlaySound(soundFile);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string soundFile = "./audio/2.wav";
            PlaySound(soundFile);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string soundFile = "./audio/3.wav";
            PlaySound(soundFile);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            string soundFile = "./audio/4.wav";
            PlaySound(soundFile);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            string soundFile = "./audio/5.wav";
            PlaySound(soundFile);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            string soundFile = "./audio/6.wav";
            PlaySound(soundFile);
        }
    }
}
