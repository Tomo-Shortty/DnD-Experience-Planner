using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Experience_Planner
{
    class EncounterList
    {
        private List<Encounter> encounterList;
        //private CharacterList characterList;
        private int totalXP;
        private double totalXPAward;

        /// <summary>
        /// Constructor for the encounter list.
        /// </summary>
        public EncounterList()
        {
            //this.characterList = characterList;
            this.encounterList = new List<Encounter>();
        }

        public int GetTotalXP()
        {
            return this.totalXP;
        }

        public double GetTotalXPAward()
        {
            return this.totalXPAward;
        }
    }
}
