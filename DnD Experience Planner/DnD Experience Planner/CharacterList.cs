using System;
using System.Collections.Generic;

public class CharacterList
{
	private List<Character> characterList;
	private int numCharacters;
	private int totalEasyXP;
	private int totalMediumXP;
	private int totalHardXP;
	private int totalDeadlyXP;
	private int totalAdventuringDayXP;

	public CharacterList()
	{
		this.characterList = new List<Character>();
	}

	public int GetNumCharacters()
    {
		return this.characterList.Count;
    }

	public int GetTotalEasyXP()
    {
		return this.totalEasyXP;
    }

	public int GetMediumXP()
    {
		return this.totalMediumXP;
    }

	public int GetHardXP()
    {
		return this.totalHardXP;
    }

	public int GetDeadlyXP()
    {
		return this.totalDeadlyXP;
    }

	public int GetAdventuringDayXP()
    {
		return this.totalAdventuringDayXP;
    }

	public Character CreateCharacter(string characterLevel)
    {
		return new Character(characterLevel);
    }

	public void AddCharacter(Character character)
    {

    }

	public void ClearCharacterList()
    {
		this.characterList.Clear();
    }
}
