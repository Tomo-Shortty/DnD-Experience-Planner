using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Experience_Planner
{
    class Encounter
    {
        private MonsterList monsterList;
        private int totalEncounterXP;
        private double XPAward;
        private string difficulty;

        /// <summary>
        /// Constructor for encounter.
        /// </summary>
        /// <param name="monsterList"></param>
        public Encounter(MonsterList monsterList)
        {
            this.monsterList = monsterList;
            this.totalEncounterXP = monsterList.GetTotalMonsterXP();
            this.XPAward = monsterList.GetXPAward();
            this.difficulty = monsterList.GetEncounterDifficulty();
        }

        /// <summary>
        /// Returns the total encounter experience.
        /// </summary>
        /// <returns></returns>
        public int GetTotalEncounterXP()
        {
            return this.totalEncounterXP;
        }

        /// <summary>
        /// Returns the experience to award each character.
        /// </summary>
        /// <returns></returns>
        public double GetXPAward()
        {
            return this.XPAward;
        }

        /// <summary>
        /// Returns the difficulty of the encounter.
        /// </summary>
        /// <returns></returns>
        public string GetDifficulty()
        {
            return this.difficulty;
        }
    }
}
