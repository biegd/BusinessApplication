using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataAccessLayer;

// https://www.youtube.com/watch?v=UPHry14bqvc

namespace BusinessApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApiService _apiService;

        public MainWindow()
        {
            InitializeComponent();
            _apiService = new ApiService(Environment.GetEnvironmentVariable("API_URL"));
        }



        private async void btn_go_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string data = await _apiService.GetDataFromApiAsync("endpoint");
                l_Data.Content = data;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}