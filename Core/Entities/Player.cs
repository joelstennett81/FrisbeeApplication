using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

namespace FrisbeeApplication.Core.Entities
{
    public class Player
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string JerseyNumber { get; set; }
        public int Overall { get; set; }
        private int Height { get; set; }    // In inches
        private int Weight { get; set; }    // In pounds
        public bool IsHandle { get; set; } // If is true, they are a handler
        public bool HasDisc { get; set; }   // If true, they have the disc
        private int Speed { get; set; }
        private int Jumping { get; set; }
        private int FlickDistance { get; set; }
        private int FlickAccuracy { get; set; }
        private int BackhandAccuracy { get; set; }
        private int BackhandDistance { get; set; }
        private int CutterDefense { get; set; }
        private int HandlerDefense { get; set; }
        private int Agility { get; set; }
        private int HandleCuts { get; set; }    // Not sure how to use it
        private int UnderCuts { get; set; } // Under and deep cuts determine cut ability
        private int DeepCuts { get; set; }
        public int ThrowAbility { get; set; }
        public int GameGoals { get; set; }
        public int SeasonGoals { get; set; }
        public int GameAssists { get; set; }
        public int SeasonAssists { get; set; }
        public int CutAbility { get; set; }
        public string TeamNameAndMascot { get; set; }
    }
}
