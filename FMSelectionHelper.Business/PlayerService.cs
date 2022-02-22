using FMSelectionHelper.FileHandler;
using FMSelectionHelper.Models;

namespace FMSelectionHelper.Business
{
    public class PlayerService
    {
        public List<Player> GetPlayersFromSquad(string path, Formation formation)
        {
            SaveGameReader reader = new SaveGameReader();
            List<Player> players = reader.ParseFile(path);
            foreach (Player player in players)
            {
                player.ComputeScores(formation);
            }
            return players;
        }
    }
}
