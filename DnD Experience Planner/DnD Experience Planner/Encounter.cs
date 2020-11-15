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
        /// <returns>The total experience</returns>
        public int GetTotalEncounterXP()
        {
            return this.totalEncounterXP;
        }

        /// <summary>
        /// Returns the experience to award each character.
        /// </summary>
        /// <returns>The total experience to award each character</returns>
        public double GetXPAward()
        {
            return this.XPAward;
        }

        /// <summary>
        /// Returns the difficulty of the encounter.
        /// </summary>
        /// <returns>The encounter difficulty</returns>
        public string GetDifficulty()
        {
            return this.difficulty;
        }

        /// <summary>
        /// Gets the quantity and challenge rating of each monster in the monster list so it can be displayed in the encounter list.
        /// </summary>
        /// <returns>A string displaying the quantity and challenge rating of each monster</returns>
        public string GetMonsterDetails()
        {
            string details = "";

            for (int i = 0; i < this.monsterList.GetMonsterListCount(); i++)
            {
                if (this.monsterList.GetMonster(i).GetNumberOfMonsters() > 1)
                {
                    details += Convert.ToString(this.monsterList.GetMonster(i).GetNumberOfMonsters()) + " monsters with a CR of " + this.monsterList.GetMonster(i).GetChallengeRating() + "\n";
                }
                else
                {
                    details += Convert.ToString(this.monsterList.GetMonster(i).GetNumberOfMonsters()) + " monster with a CR of " + this.monsterList.GetMonster(i).GetChallengeRating() + "\n";
                }
            }

            return details;
        }
    }
}
