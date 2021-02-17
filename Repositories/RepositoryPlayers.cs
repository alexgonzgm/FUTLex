using FUTLex.Data;
using FUTLex.Helpers;
using FUTLex.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FUTLex.Repositories
{
    public class RepositoryPlayers : IRepositoryPlayers
    {
        private ApplicationDbContext context;
        public RepositoryPlayers(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void FicharJugador(int id, string search)
        {
            List<Player> jugadores = this.GetPlayersSearch(search);
            Player player = jugadores.Where(x => x.id == id).SingleOrDefault();
            this.context.Players.Add(player);
            this.context.SaveChanges();

        }

        public List<int> GetJuagoresFichadosIds()
        {
            List<int> ids = new List<int>();
            List<Player> players = this.GetJugadoresFichados();
            ids = players.Select(x => x.id).ToList();
            return ids;

        }
        public List<Player> GetJugadoresFichados()
        {
            List<Player> players = this.context.Players.ToList();
            return players;
        }

        public Player GetPlayer(int id, string search)
        {
            List<Player> jugadores = this.GetPlayersSearch(search);
            Player player = jugadores.Where(x => x.id == id).SingleOrDefault();
            return player;
        }

        public List<Player> GetPlayersSearch(string nombre)
        {
            string url = "https://www.futbin.com/search?year=21&extra=1&v=1&term=";
            string searh = url + nombre;
            string json =  ToolkitService.GetWebRequest(searh);
            return ToolkitService.DeserializeJsonObject<List<Player>>(json);
        }

        public List<Prices> GetPrices(int id)
        {
            string url = "Https://www.futbin.com/21/playerPrices?player=";
            string searh = url + id;
            string json = ToolkitService.GetWebRequest(searh);
            Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(json);
            IList<JToken> data = obj[id.ToString()]["prices"].Children().ToList();

            return ToolkitService.DeserializeJsonObject<List<Prices>>(json);
        }
    }
}
