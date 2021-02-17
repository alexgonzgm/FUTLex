using FUTLex.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FUTLex.Helpers
{
    public class ToolkitService
    {
        public static  string GetWebRequest(string url)
        {
            string jsonstring = string.Empty;
            HttpWebResponse response;
            HttpWebRequest request;
            try
            {
               
                 request = WebRequest.Create(url) as HttpWebRequest;

                 response = request.GetResponse() as HttpWebResponse;

            }
            catch (Exception  e)
            {

                throw e;
            }
          
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                jsonstring = reader.ReadToEnd();
                reader.Close();
            }
           
            
            return jsonstring;
        }
      


        public static String SerializeJsonObject(object objeto)
        {
            String respuesta =
                JsonConvert.SerializeObject(objeto);
            return respuesta;
        }

        
        public static T DeserializeJsonObject<T>(String json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static List<string> GetSatats(string id)
        {
            List<string> valores = new List<string>();
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.futbin.com/21/player/" + id);
            foreach (var Nodo in doc.DocumentNode.CssSelect(".stats-inner .stat_val .stat_val"))
            {
                valores.Add(Nodo.InnerHtml);
            }
            return valores;
        }

        public static Player MapeoDeStats(Player player,List<int> stats)
        {

            player.Pace = stats[0];
            player.Acceleration    = stats[1];
            player.SprintSpeed     = stats[2];
            player.Shooting        = stats[3];
            player.Positioning     = stats[4];
            player.Finishing       = stats[5];
            player.ShotPower       = stats[6];
            player.LongShots       = stats[7];
            player.Volleys         = stats[8];
            player.Penalties       = stats[9];
            player.Passing         = stats[10];
            player.Visiion         = stats[11];
            player.Crossing        = stats[12];
            player.FkAccuaracy     = stats[13];
            player.ShortPassing    = stats[14];
            player.LongPassing     = stats[15];
            player.Curve           = stats[16];
            player.DribblingTotal  = stats[17];
            player.Agility         = stats[18];
            player.Balance         = stats[19];
            player.Reactions       = stats[20];
            player.BallControl     = stats[21];
            player.Dribbling       = stats[22];
            player.Composturte     = stats[23];
            player.Defending       = stats[24];
            player.Interceptions   = stats[25];
            player.HeadingAcuaricy = stats[26];
            player.Marking         = stats[27];
            player.StandingTackle  = stats[28];
            player.SlindingTackle  = stats[29];
            player.PHYSICALITY     = stats[30];
            player.Jumping         = stats[31];
            player.Stamina         = stats[32];
            player.Strength = stats[33];
            player.Agression = stats[34];
            return player;
                                 
        }
    }
}
