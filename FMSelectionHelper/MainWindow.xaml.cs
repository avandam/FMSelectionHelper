using System;
using System.Collections.Generic;
using System.IO;
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
        private List<Formation> formations = new List<Formation>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = players;
            FindAvailableFormations();
        }

        private void FindAvailableFormations()
        {
            FormationService service = new FormationService();
            this.formations = service.GetFormations();
            CmbFormations.ItemsSource = formations;
            CmbFormations.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    players = playerService.GetPlayersFromSquad(openFileDialog.FileName, CmbFormations.SelectedItem as Formation);
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
            string sortBy = string.Empty;
            if (column?.Tag != null)
            {
                sortBy = column?.Tag.ToString() ?? string.Empty;
            }

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

        private void Btn_FormationManager_OnClick(object sender, RoutedEventArgs e)
        {
            FormationManager manager = new FormationManager();
            manager.Show();
        }
    }
}
