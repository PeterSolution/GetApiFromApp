using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;

namespace ClientFrontEnd
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }
    }
    public async void get()
    {
        HttpClient client = new HttpClient();
        try
        {
            // Zaktualizuj URL do odpowiedniego endpointu API
            string apiUrl = "https://localhost:5001/api/data";
            Data data = await client.GetFromJsonAsync<Data>(apiUrl);

            if (data != null)
            {
                MessageBox.Show($"Id: {data.Id}, Name: {data.Name}", "Data Retrieved");
            }
            else
            {
                MessageBox.Show("No data retrieved.", "Error");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error");
        }
    }
}
