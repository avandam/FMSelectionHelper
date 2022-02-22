using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using FMSelectionHelper.Business;
using FMSelectionHelper.Models;
using Microsoft.Win32;
// ReSharper disable RedundantExtendsListEntry

namespace FMSelectionHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sortPosition = string.Empty;
        private readonly PlayerService playerService = new PlayerService();
        private List<Player> players = new List<Player>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    players = playerService.GetPlayersFromSquad(openFileDialog.FileName);
                    PlayersView.ItemsSource = players;
                    for (int i = 0; i < 11; i++)
                    {
                        if (PlayerGrid.Columns[i + 5].Header is GridViewColumnHeader header)
                        {
                            header.Content = players[i].RoleScores[i].Position.Position.PositionType.ToDescriptionString();
                            header.ToolTip = players[i].RoleScores[i].Position.Role;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Something went wrong");
            }
        }

        private void PlayersViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader? column = (sender as GridViewColumnHeader);
            string sortBy = column?.Tag.ToString() ?? string.Empty;
            if (sortBy == sortPosition)
            {
                PlayersView.ItemsSource = players;
                sortPosition = string.Empty;
                return;
            }

            sortPosition = sortBy;
            int index = Convert.ToInt32(sortBy.Substring(3));
            var orderedPlayers = players.OrderByDescending(player => player.GetRoleScore(index)).ToList();
            PlayersView.ItemsSource = orderedPlayers;
        }
    }
}
