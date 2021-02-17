using FUTLex.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FUTLex.Repositories
{
    public interface IRepositoryPlayers
    {
        public List<Player> GetPlayersSearch(string nombre);
        public Player GetPlayer(int id  , string search);
        public void FicharJugador(int id, string search);
        public List<int> GetJuagoresFichadosIds();
        public List<Player> GetJugadoresFichados();
        public List<Prices> GetPrices(int id);
    }
}
