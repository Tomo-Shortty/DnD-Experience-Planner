using System;
using System.Collections.Generic;

public class CharacterList
{
	private List<Character> characterList;
	private int totalEasyXP;
	private int totalMediumXP;
	private int totalHardXP;
	private int totalDeadlyXP;
	private int totalAdventuringDayXP;

	public CharacterList()
	{
		this.characterList = new List<Character>();
	}

	/*
	 * Gets the number of character elements in the character list.
	 */
	public int GetNumCharacterRows()
    {
		return this.characterList.Count;
    }

	/*
	 * Gets the total 'Easy' experience.
	 */
	public int GetTotalEasyXP()
    {
		return this.totalEasyXP;
    }

	/*
	 * Gets the total 'Medium' experience.
	 */
	public int GetTotalMediumXP()
    {
		return this.totalMediumXP;
    }

	/*
	 * Gets the total 'Hard' experience.
	 */
	public int GetTotalHardXP()
    {
		return this.totalHardXP;
    }

	/*
	 * Gets the total 'Deadly' experience.
	 */
	public int GetTotalDeadlyXP()
    {
		return this.totalDeadlyXP;
    }

	/*
	 * Gets the total adventuring day experience that is recommended for the characters in the list.
	 */
	public int GetTotalAdventuringDayXP()
    {
		return this.totalAdventuringDayXP;
    }

	/*
	 * Creates a new character element that is to be added the character list.
	 */
	public Character CreateCharacter(string characterLevel, int quantity)
    {
		return new Character(characterLevel, quantity);
    }

	/*
	 * Adds a character element to the character list.
	 */
	public void AddToCharacterList(Character character)
    {
		this.characterList.Add(character);
    }

	/*
	 * Clears the character list and resets all total experience values.
	 */
	public void ClearCharacterList()
    {
		this.characterList.Clear();
		this.totalEasyXP = 0;
		this.totalMediumXP = 0;
		this.totalHardXP = 0;
		this.totalDeadlyXP = 0;
		this.totalAdventuringDayXP = 0;
    }

	/*
	 * Calculates the total experience values in the character list. Assumes character experience has already
	 * been assigned to each character element.
	 */
	public void CalculateTotalCharacterXP()
    {
		foreach (Character character in this.characterList) {
			this.totalEasyXP += character.GetEasyCharacterXP();
			this.totalMediumXP += character.GetMediumCharacterXP();
			this.totalHardXP += character.GetHardCharacterXP();
			this.totalDeadlyXP += character.GetDeadlyCharacterXP();
			this.totalAdventuringDayXP += character.GetAdventuringDayXP();
        }
    }
}
