using SwissTransport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TransportFinderClient
{
    public partial class TransportFinderView : Form
    {

        private readonly Transport _transport;

        public TransportFinderView()
        {
            InitializeComponent();

            _transport = new Transport();

            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            chbSpecifyTime.Checked = false;
            dtpTime.Enabled = false;
        }

        private void CmbStartLocation_TextUpdate(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(cmbStartLocation.Text ?? "");

            cmbStartLocation.Items.Clear();

            if (stations.StationList.Count == 0)
            {
                return;
            }

            foreach (Station station in stations.StationList)
            {
                if (string.IsNullOrEmpty(station.Name))
                {
                    continue;
                }

                cmbStartLocation.Items.Add(station.Name);
            }

            cmbStartLocation.SelectionStart = cmbStartLocation.Text.Length;
        }

        private void CmbDestinationLocation_TextUpdate(object sender, EventArgs e)
        {
            Stations stations = _transport.GetStations(cmbDestinationLocation.Text ?? "");

            cmbDestinationLocation.Items.Clear();

            if (stations.StationList.Count == 0)
            {
                return;
            }

            foreach (Station station in stations.StationList)
            {
                if (string.IsNullOrEmpty(station.Name))
                {
                    continue;
                }

                cmbDestinationLocation.Items.Add(station.Name);
            }

            cmbDestinationLocation.SelectionStart = cmbDestinationLocation.Text.Length;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ltvConnections.Items.Clear();

            Connections connections = _transport.GetConnections(cmbStartLocation.Text, cmbDestinationLocation.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                string[] values = new string[]
                {
                    DateTime.Parse(connection.From.Departure).ToString("g"),
                    connection.Duration,
                    DateTime.Parse(connection.To.Arrival).ToString("g")
                   
                };


                ltvConnections.Items.Add(new ListViewItem(values)
                {
                    Tag = connection
                });




            }
        }

        private void AbfahrtsTaffle_Click(object sender, EventArgs e)
        {
            ltvConnections.Items.Clear();
            List<StationBoard> stationBoards = _transport.GetStationBoard(cmbStartLocation.Text, "").Entries;
            foreach (StationBoard stationBoard in stationBoards)
            {
                string[] values = new string[]
                {
                stationBoard.Stop.Station.Name,
                stationBoard.Stop.Departure.ToString("g"),
                stationBoard.To,
                ""
                };
                ltvConnections.Items.Add(new ListViewItem(values)
                {
                    Tag = stationBoard
                });
            }

        }
    }
}
