using System.Windows;

namespace GreenwardGuide
{
    public partial class MainWindow : Window
    {
        private int currentPage = 0;

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
            }
            else if (currentPage == 2)
            {
                GuidePage.Visibility = Visibility.Visible;

                GuideTitle.Text = "Garden Area";
                GuideImage.Text = "[ GARDEN ILLUSTRATION ]";

                GuideDescription.Text =
                    "Follow the marked path toward the garden area. " +
                    "Use the illustrations to identify important locations.";
            }
            else if (currentPage == 3)
            {
                GuidePage.Visibility = Visibility.Visible;

                GuideTitle.Text = "Overgrown Area";
                GuideImage.Text = "[ FOREST ILLUSTRATION ]";

                GuideDescription.Text =
                    "Roads and buildings may be difficult to recognize " +
                    "because the surrounding forest has grown over them.";
            }

            BackButton.IsEnabled = currentPage > 0;
            NextButton.IsEnabled = currentPage < 3;
        }
    }
}