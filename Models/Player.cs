using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FUTLex.Models
{
    public class Player
    {
        public int rating { get; set; }
        public string position { get; set; }
        public string club_image { get; set; }
        public string image { get; set; }
        public int rare_type { get; set; }
        public string full_name { get; set; }
        public string url_name { get; set; }
        public string name { get; set; }
        [Key]
        public int id { get; set; }
        public string nation_image { get; set; }
        public int rare { get; set; }
        public string version { get; set; }

        public int Pace { get; set; }
        public int Acceleration { get; set; }
        public int SprintSpeed { get; set; }
        public int Shooting { get; set; }
        public int Positioning { get; set; }
        public int Finishing { get; set; }
        public int ShotPower { get; set; }
        public int LongShots { get; set; }
        public int Volleys { get; set; }
        public int Penalties { get; set; }
        public int Passing { get; set; }
        public int Visiion {get; set;}
        public int Crossing {get; set;}
        public int FkAccuaracy {get; set;}
        public int ShortPassing {get; set;}
        public int LongPassing {get; set;}
        public int Curve {get; set;}
        public int DribblingTotal {get; set;}
        public int Agility {get; set;}
        public int Balance {get; set;}
        public int Reactions {get; set;}
        public int BallControl {get; set;}
        public int Dribbling {get; set;}
        public int Composturte {get; set;}
        public int Defending {get; set;}
        public int Interceptions {get; set;}
        public int HeadingAcuaricy {get; set;}
        public int Marking {get; set;}
        public int StandingTackle {get; set;}
        public int SlindingTackle {get; set;}
        public int PHYSICALITY { get; set;}
        public int Jumping { get; set;}
        public int Stamina {get; set;}
        public int Strength {get; set;}
        public int Agression {get; set;}
      
    }
}
