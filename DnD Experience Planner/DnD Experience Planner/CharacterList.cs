using System;
using System.Collections.Generic;

public class CharacterList
{
	private List<Character> characterList;
	private int totalCharacters;
	private int totalEasyXP;
	private int totalMediumXP;
	private int totalHardXP;
	private int totalDeadlyXP;
	private int totalAdventuringDayXP;

	/*
	 * Constructor for the character list.
	 */
	public CharacterList()
	{
		this.characterList = new List<Character>();
	}

	/*
	 * Gets the total number of individual characters in the character list.
	 */
	public int GetTotalNumberOfCharacters()
    {
		return this.totalCharacters;
    }

	/*
	 * Gets the total number of elements in the character list.
	 */
	public int GetCharacterListCount()
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
	 * Sets the experience of the character element and adds it to the character list.
	 */
	public void AddToCharacterList(Character character)
    {
		character.SetCharacterXP(character.GetCharacterLevel());
		this.characterList.Add(character);
    }

	/*
	 * Removes a character element from the list. An index is used to determine the element to remove.
	 */
	public void RemoveCharacterFromList(int index)
    {
		this.characterList.RemoveAt(index);
    }

	/*
	 * Clears the character list and resets all total experience values.
	 */
	public void ClearCharacterList()
    {
		this.characterList.Clear();
		ResetCharacterTotals();
    }

	/*
	 * Calculates the total number of characters and experience values in the character list. Assumes character experience 
	 * has already been assigned to each character element.
	 */
	public void CalculateCharacterTotals()
    {
		ResetCharacterTotals();

		foreach (Character character in this.characterList) {
			this.totalCharacters += character.GetNumberOfCharacters();
			this.totalEasyXP += character.GetEasyCharacterXP();
			this.totalMediumXP += character.GetMediumCharacterXP();
			this.totalHardXP += character.GetHardCharacterXP();
			this.totalDeadlyXP += character.GetDeadlyCharacterXP();
			this.totalAdventuringDayXP += character.GetAdventuringDayXP();
        }
    }

	/*
	 * Resets all total experience values.
	 */
	private void ResetCharacterTotals()
    {
		this.totalCharacters = 0;
		this.totalEasyXP = 0;
		this.totalMediumXP = 0;
		this.totalHardXP = 0;
		this.totalDeadlyXP = 0;
		this.totalAdventuringDayXP = 0;
	}
}
