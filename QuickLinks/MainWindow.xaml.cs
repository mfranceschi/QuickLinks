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

namespace QuickLinks
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string GOOGLE_URL = "https://www.google.fr";
        public const string MFRANCESCHI_GITHUB_URL = "https://github.com/mfranceschi";
        public const string MFRANCESCHI_LINKEDIN_URL = "https://www.linkedin.com/in/martin-franceschi-031292146/";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoogleLinkButton_Click(object sender, RoutedEventArgs e)
        {
            openUrl(GOOGLE_URL);
        }

        private void MfranceschiGitHubLinkButton_Click(object sender, RoutedEventArgs e)
        {
            openUrl(MFRANCESCHI_GITHUB_URL);
        }

        private void MfranceschiLinkedInLinkButton_Click(object sender, RoutedEventArgs e)
        {
            openUrl(MFRANCESCHI_LINKEDIN_URL);
        }

        private void openUrl(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
