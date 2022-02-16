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
using FMSelectionHelper.Business;
using FMSelectionHelper.Models;
using Microsoft.Win32;

namespace FMSelectionHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sortPosition = String.Empty;
        private readonly PlayerService playerService = new PlayerService();
        private List<Player> players = new List<Player>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                players = playerService.GetPlayersFromSquad(openFileDialog.FileName);
                PlayersView.ItemsSource = players;
            }
        }

        private void PlayersViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            List<Player> orderedPlayers;
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (sortBy == sortPosition)
            {
                PlayersView.ItemsSource = players;
                sortPosition = string.Empty;
                return;
            }

            sortPosition = sortBy;
            if (sortBy == "GK")
            {
                orderedPlayers = players.OrderByDescending(player => player.GkScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "DL")
            {
                orderedPlayers = players.OrderByDescending(player => player.DLScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "DC")
            {
                orderedPlayers = players.OrderByDescending(player => player.DCScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "DR")
            {
                orderedPlayers = players.OrderByDescending(player => player.DRScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "DLP")
            {
                orderedPlayers = players.OrderByDescending(player => player.DLPScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "BBM")
            {
                orderedPlayers = players.OrderByDescending(player => player.BBMScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "AML")
            {
                orderedPlayers = players.OrderByDescending(player => player.AMLScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "AMC")
            {
                orderedPlayers = players.OrderByDescending(player => player.AMCScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "AMR")
            {
                orderedPlayers = players.OrderByDescending(player => player.AMRScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
            else if (sortBy == "ST")
            {
                orderedPlayers = players.OrderByDescending(player => player.STScore).ToList();
                PlayersView.ItemsSource = orderedPlayers;
            }
        }
    }
}
