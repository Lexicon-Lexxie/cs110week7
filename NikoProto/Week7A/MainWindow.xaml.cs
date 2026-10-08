using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GreenwardGuide
{
    public partial class MainWindow : Window
    {
        private int currentPage = 0;
        private BitmapSource? capturedImage;

        public MainWindow()
        {
            InitializeComponent();
            ShowPage();
        }

        private void StartGuide_Click(object sender, RoutedEventArgs e)
        {
            currentPage = 1;
            ShowPage();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowPage();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage < 3)
            {
                currentPage++;
                ShowPage();
            }
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            currentPage = 0;
            ShowPage();
        }

        private void ShowPage()
        {
            HomePage.Visibility = Visibility.Collapsed;
            MapPage.Visibility = Visibility.Collapsed;
            GuidePage.Visibility = Visibility.Collapsed;

            if (currentPage == 0)
            {
                HomePage.Visibility = Visibility.Visible;
            }
            else if (currentPage == 1)
            {
                MapPage.Visibility = Visibility.Visible;
                try
                {
                    var assetsDir = Path.Combine(AppContext.BaseDirectory, "Assets");
                    var mapPath = Path.Combine(assetsDir, "1.png");
                    MapImage.Source = System.IO.File.Exists(mapPath)
                        ? new BitmapImage(new Uri(mapPath, UriKind.Absolute))
                        : null;
                }
                catch { MapImage.Source = null; }
                // Slide 1 — Arrival
                try
                {
                    MapTitle.Text = "Arrival";
                    MapDescription.Text =
                        "You have arrived in Greenward from Kairova’s tech department to help Sana Vey and her new garden crew. " +
                        "The protected pods were still working, but outside, the forest had taken over the old roads and buildings. " +
                        "This caused the connection and systems to go down. The garden operators needed your guidance.";
                }
                catch { /* ignore UI update errors */ }
            }
            else if (currentPage == 2)
            {
                GuidePage.Visibility = Visibility.Visible;

                GuideTitle.Text = "Garden Area";
                try
                {
                    var assetsDir = Path.Combine(AppContext.BaseDirectory, "Assets");
                    var guidePath = Path.Combine(assetsDir, "2.png");
                    GuideImageControl.Source = System.IO.File.Exists(guidePath)
                        ? new BitmapImage(new Uri(guidePath, UriKind.Absolute))
                        : null;
                }
                catch { GuideImageControl.Source = null; }

                GuideDescription.Text =
                    "Follow the marked path toward the garden area. " +
                    "Use the illustrations to identify important locations.";
            }
            else if (currentPage == 3)
            {
                GuidePage.Visibility = Visibility.Visible;


                GuideTitle.Text = "Overgrown Area";
                try
                {
                    var assetsDir = Path.Combine(AppContext.BaseDirectory, "Assets");
                    var slide3 = Path.Combine(assetsDir, "3.png");
                    GuideImageControl.Source = System.IO.File.Exists(slide3)
                        ? new BitmapImage(new Uri(slide3, UriKind.Absolute))
                        : null;
                }
                catch { GuideImageControl.Source = null; }

                GuideDescription.Text =
                    "Roads and buildings may be difficult to recognize " +
                    "because the surrounding forest has grown over them.";
            }

            BackButton.IsEnabled = currentPage > 0;
            NextButton.IsEnabled = currentPage < 3;
        }

        private void CaptureButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                capturedImage = CaptureService.CapturePrimaryScreen();
                CapturePreview.Source = capturedImage;
                SaveCaptureButton.IsEnabled = true;
                ClearCaptureButton.IsEnabled = true;
                StatusText.Text = "Capture ready. Inspect it before saving or sharing.";
            }
            catch (Exception ex)
            {
                StatusText.Text = "Capture failed: " + ex.Message;
            }
        }

        private void SaveCaptureButton_Click(object sender, RoutedEventArgs e)
        {
            if (capturedImage is null) return;
            var dialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "PNG image|*.png", DefaultExt = ".png",
                AddExtension = true, FileName = "story-capture.png", OverwritePrompt = true
            };
            if (dialog.ShowDialog(this) != true)
            {
                StatusText.Text = "Save cancelled. Preview kept.";
                return;
            }
            try
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(capturedImage));
                using var file = File.Create(dialog.FileName);
                encoder.Save(file);
                StatusText.Text = "PNG saved: " + dialog.FileName;
            }
            catch (Exception ex)
            {
                StatusText.Text = "Save failed. Choose a writable folder. " + ex.Message;
            }
        }

        private void ClearCaptureButton_Click(object sender, RoutedEventArgs e)
        {
            capturedImage = null;
            CapturePreview.Source = null;
            SaveCaptureButton.IsEnabled = false;
            ClearCaptureButton.IsEnabled = false;
            StatusText.Text = "Preview cleared. Story position kept.";
        }
    }
}