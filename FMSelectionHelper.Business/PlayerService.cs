using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSelectionHelper.FileHandler;
using FMSelectionHelper.Models;

namespace FMSelectionHelper.Business
{
    public class PlayerService
    {
        private List<Role> roles = new List<Role>();
        public List<Player> GetPlayersFromSquad(string path)
        {
            SaveGameReader reader = new SaveGameReader();
            List<Player> players = reader.ParseFile(path);
            CreateRoles();
            foreach (Player player in players)
            {
                player.ComputeScores();
            }
            return players;
        }

        private void CreateRoles()
        {

        }
    }
}
