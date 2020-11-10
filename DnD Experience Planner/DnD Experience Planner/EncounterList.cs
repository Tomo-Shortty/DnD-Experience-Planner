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

        public int GetTotalXP()
        {
            return this.totalXP;
        }

        public double GetTotalXPAward()
        {
            return this.totalXPAward;
        }

        public void AddToEncounterList(Encounter encounter)
        {
            this.encounterList.Add(encounter);

        }

        public void RemoveFromEncounterList(int index)
        {
            this.encounterList.RemoveAt(index);
        }

        public void ClearEncounterList()
        {
            this.encounterList.Clear();
            ResetEncounterTotals();
        }

        public void CalculateEncounterTotals()
        {
            ResetEncounterTotals();

            foreach(Encounter encounter in this.encounterList)
            {
                this.totalXP += encounter.GetTotalEncounterXP();
                this.totalXPAward += encounter.GetXPAward();
            }
        }

        private void ResetEncounterTotals()
        {
            this.totalXP = 0;
            this.totalXPAward = 0;
        }
    }
}
