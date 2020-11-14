using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MonsterList
{
	private List<Monster> monsterList;
	private int totalNumberOfMonsters;
	private int totalMonsterXP;
	private double XPAward;
	private double adjustedMonsterXP;
	private string encounterDifficulty;

	/*
	 * Constructor for the monster list.
	 */
	public MonsterList()
	{
		this.monsterList = new List<Monster>();
	}

	/*
	 * Gets the monster element at the specified index.
	 */
	public Monster GetMonster(int index)
    {
		return this.monsterList[index];
    }

	/*
	 * Gets the total number of monsters in the list.
	 */
	public int GetTotalNumberOfMonsters()
	{
		return this.totalNumberOfMonsters;
	}

	/*
	 * Gets the number of elements in the monster list.
	 */
	public int GetMonsterListCount()
    {
		return this.monsterList.Count;
    }

	/*
	 * Gets the total monster experience calculated from the list.
	 */
	public int GetTotalMonsterXP()
    {
		return this.totalMonsterXP;
    }

	/*
	 * Gets the experience that is awarded to each player.
	 */
	public double GetXPAward()
    {
		return this.XPAward;
    }

	/*
	 * Gets the adjusted monster experience.
	 */
	public double GetAdjustedMonsterXP()
    {
		return this.adjustedMonsterXP;
    }

	/*
	 * Gets the encounter difficulty.
	 */
	public string GetEncounterDifficulty()
    {
		return this.encounterDifficulty;
    }

	/*
	 * Sets the experience of the monster element and adds it to the monster list.
	 */
	public void AddtoMonsterList(Monster monster)
    {
		monster.SetMonsterXP(monster.GetChallengeRating());
		this.monsterList.Add(monster);
    }

	/*
	 * Removes a monster element from the list. An index is used to determine the element to remove.
	 */
	public void RemoveMonsterFromList(int index)
    {
		this.monsterList.RemoveAt(index);
    }

	/*
	 * Clears the monster list resets all values.
	 */
	public void ClearMonsterList()
    {
		this.monsterList.Clear();
		ResetMonsterTotals();
    }

	/*
	 * Calculates the total number of monsters and experience values in the monster list. Assumes monster experience has already been
	 * set and a character list is available.
	 */
	public void CalculateMonsterTotals(CharacterList characterList)
    {
		ResetMonsterTotals();

		foreach (Monster monster in this.monsterList)
        {
			this.totalNumberOfMonsters += monster.GetNumberOfMonsters();
			this.totalMonsterXP += monster.GetMonsterXP();
        }

		this.adjustedMonsterXP = Convert.ToDouble(this.totalMonsterXP); //set the adjusted monster experience

		//calculate the experience to award individual characters if there is more than 0 characters in the character list
		if (characterList.GetTotalNumberOfCharacters() > 0)
        {
			this.XPAward = Convert.ToDouble(this.totalMonsterXP) / Convert.ToDouble(characterList.GetTotalNumberOfCharacters());
        } 
		else
        {
			this.XPAward = 0.0;
        }

		//modify the adjusted monster experience based on the total number of monsters. Does not change if total number of monsters is 1
		if (this.totalNumberOfMonsters == 2)
        {
			this.adjustedMonsterXP *= 1.5;
        }
		else if (this.totalNumberOfMonsters >= 3 && this.totalNumberOfMonsters <= 6)
        {
			this.adjustedMonsterXP *= 2;
        }
		else if (this.totalNumberOfMonsters >= 7 && this.totalNumberOfMonsters <= 10)
        {
			this.adjustedMonsterXP *= 2.5;
        }
		else if (this.totalNumberOfMonsters >= 11 && this.totalNumberOfMonsters <= 14)
        {
			this.adjustedMonsterXP *= 3;
        }
		else if (this.totalNumberOfMonsters >= 15)
        {
			this.adjustedMonsterXP *= 4;
        }

		//determine the encounter difficulty by comparing the adjusted monster XP with total character list XP
		if (this.adjustedMonsterXP >= characterList.GetTotalEasyXP())
		{
			if (this.adjustedMonsterXP >= characterList.GetTotalMediumXP())
			{
				if (this.adjustedMonsterXP >= characterList.GetTotalHardXP())
				{
					if (this.adjustedMonsterXP >= characterList.GetTotalDeadlyXP())
					{
						this.encounterDifficulty = "Deadly";
					}
					else
					{
						this.encounterDifficulty = "Hard";
					}
				}
				else
				{
					this.encounterDifficulty = "Medium";
				}
			}
			else
			{
				this.encounterDifficulty = "Easy";
			}
		}
		else
		{
			this.encounterDifficulty = "Very Easy";
		}
	}

	/*
	 * Resets all total values.
	 */
	private void ResetMonsterTotals()
    {
		this.totalNumberOfMonsters = 0;
		this.totalMonsterXP = 0;
		this.XPAward = 0;
		this.adjustedMonsterXP = 0;
	}
}
