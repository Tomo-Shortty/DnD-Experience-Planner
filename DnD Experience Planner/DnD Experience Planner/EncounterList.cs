using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace DnD_Experience_Planner
{
    class EncounterList
    {
        private List<Encounter> encounterList;
        private int totalXP;
        private double totalXPAward;

        /// <summary>
        /// Constructor for the encounter list.
        /// </summary>
        public EncounterList()
        {
            this.encounterList = new List<Encounter>();
        }

        /// <summary>
        /// Gets the total experience of the encounter list.
        /// </summary>
        /// <returns>The total experience</returns>
        public int GetTotalXP()
        {
            return this.totalXP;
        }

        /// <summary>
        /// Gets the total experience to award each player.
        /// </summary>
        /// <returns>The total experience to award each player</returns>
        public double GetTotalXPAward()
        {
            return this.totalXPAward;
        }

        /// <summary>
        /// Adds an encounter to the list and adds the total experience from the encounter.
        /// </summary>
        /// <param name="encounter">The encounter to add to the list</param>
        public void AddToEncounterList(Encounter encounter)
        {
            this.encounterList.Add(encounter);
            CalculateEncounterTotals();

        }

        /// <summary>
        /// Removes the encounter from the list then updates the experience totals.
        /// </summary>
        /// <param name="index">The pointer to the encounter to remove</param>
        public void RemoveFromEncounterList(int index)
        {
            this.encounterList.RemoveAt(index);
            CalculateEncounterTotals();
        }

        /// <summary>
        /// Clears the entire encounter list and resets the totals.
        /// </summary>
        public void ClearEncounterList()
        {
            this.encounterList.Clear();
            ResetEncounterTotals();
        }

        /// <summary>
        /// Calculates the lists' experience totals.
        /// </summary>
        private void CalculateEncounterTotals()
        {
            ResetEncounterTotals();

            foreach(Encounter encounter in this.encounterList)
            {
                this.totalXP += encounter.GetTotalEncounterXP();
                this.totalXPAward += encounter.GetXPAward();
            }
        }

        /// <summary>
        /// Resets all totals in the list.
        /// </summary>
        private void ResetEncounterTotals()
        {
            this.totalXP = 0;
            this.totalXPAward = 0;
        }
    }
}
