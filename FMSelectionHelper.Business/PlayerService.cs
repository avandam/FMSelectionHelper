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
        public List<Player> GetPlayersFromSquad(string path)
        {
            SaveGameReader reader = new SaveGameReader();
            return reader.ParseFile(path);
        }
    }
}
