using SwissTransport;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TransportFinderView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Transport _transport;

        public MainWindow()
        {
            InitializeComponent();

            _transport = new Transport();
        }

        private void MeineLocation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }




        private void StationSuche_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (e.Key == Key.Return )
            {

                //Abfahrtsstation.Items.Clear();
                //     Ankunftsstation.Items.Clear();

                string StationName = comboBox.Text;

                Stations stations = _transport.GetStations(StationName);


                

                foreach (Station station in stations.StationList)
                {
                    _ = comboBox.Name == "Abfahrtsstation"
                        ? Abfahrtsstation.Items.Add(station.Name)
                        : Ankunftsstation.Items.Add(station.Name);
                }
            }

        }
    }
}
