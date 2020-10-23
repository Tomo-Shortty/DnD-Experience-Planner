using System;

public class Character
{
	private string characterLevel;
	private int quantity;
	private int easyCharacterXP;
	private int mediumCharacterXP;
	private int hardCharacterXP;
	private int deadlyCharacterXP;
	private int adventuringDayXP;

	/*
	 * Constructor for the Character class. Throws an exception if character level is empty or if quantity is equal to or less than 0.
	 */
	public Character(string characterLevel, int quantity)
	{
		if (characterLevel.Equals(""))
        {
			throw new Exception("Character level has not been specified.");
        } 
		else if (quantity <= 0)
        {
			throw new Exception("Number of characters has not been specified.");
        }
		else
        {
			this.characterLevel = characterLevel;
			this.quantity = quantity;
		}
	}

	/*
	 * Gets the character level.
	 */
	public string GetCharacterLevel()
    {
		return this.characterLevel;
    }

	/*
	 * Gets the quantity.
	 */
	public int GetNumberOfCharacters()
    {
		return this.quantity;
    }

	/*
	 * Gets the 'Easy' experience.
	 */
	public int GetEasyCharacterXP()
    {
		return this.easyCharacterXP;
    }

	/*
	 * Gets the 'Medium' experience.
	 */
	public int GetMediumCharacterXP()
    {
		return this.mediumCharacterXP;
    }

	/*
	 * Gets the 'Hard' experience.
	 */
	public int GetHardCharacterXP()
    {
		return this.hardCharacterXP;
    }

	/*
	 * Gets the 'Deadly' experience.
	 */
	public int GetDeadlyCharacterXP()
    {
		return this.deadlyCharacterXP;
    }

	/*
	 * Gets the adventuring day experience.
	 */
	public int GetAdventuringDayXP()
    {
		return this.adventuringDayXP;
    }

	/*
	 * Determines the character experience to assign based on character level.
	 */
	public void SetCharacterXP(string characterLevel)
    {
		switch(characterLevel)
        {
			case "1":
				this.easyCharacterXP = 25 * this.quantity;
				this.mediumCharacterXP = 50 * this.quantity;
				this.hardCharacterXP = 75 * this.quantity;
				this.deadlyCharacterXP = 100 * this.quantity;
				this.adventuringDayXP = 300 * this.quantity;
				break;
			case "2":
				this.easyCharacterXP = 50 * this.quantity;
				this.mediumCharacterXP = 100 * this.quantity;
				this.hardCharacterXP = 150 * this.quantity;
				this.deadlyCharacterXP = 200 * this.quantity;
				this.adventuringDayXP = 600 * this.quantity;
				break;
			case "3":
				this.easyCharacterXP = 75 * this.quantity;
				this.mediumCharacterXP = 150 * this.quantity;
				this.hardCharacterXP = 225 * this.quantity;
				this.deadlyCharacterXP = 400 * this.quantity;
				this.adventuringDayXP = 1200 * this.quantity;
				break;
			case "4":
				this.easyCharacterXP = 125 * this.quantity;
				this.mediumCharacterXP = 250 * this.quantity;
				this.hardCharacterXP = 375 * this.quantity;
				this.deadlyCharacterXP = 500 * this.quantity;
				this.adventuringDayXP = 1700 * this.quantity;
				break;
			case "5":
				this.easyCharacterXP = 250 * this.quantity;
				this.mediumCharacterXP = 500 * this.quantity;
				this.hardCharacterXP = 750 * this.quantity;
				this.deadlyCharacterXP = 1100 * this.quantity;
				this.adventuringDayXP = 3500 * this.quantity;
				break;
			case "6":
				this.easyCharacterXP = 300 * this.quantity;
				this.mediumCharacterXP = 600 * this.quantity;
				this.hardCharacterXP = 900 * this.quantity;
				this.deadlyCharacterXP = 1400 * this.quantity;
				this.adventuringDayXP = 4000 * this.quantity;
				break;
			case "7":
				this.easyCharacterXP = 350 * this.quantity;
				this.mediumCharacterXP = 750 * this.quantity;
				this.hardCharacterXP = 1100 * this.quantity;
				this.deadlyCharacterXP = 1700 * this.quantity;
				this.adventuringDayXP = 5000 * this.quantity;
				break;
			case "8":
				this.easyCharacterXP = 450 * this.quantity;
				this.mediumCharacterXP = 900 * this.quantity;
				this.hardCharacterXP = 1400 * this.quantity;
				this.deadlyCharacterXP = 2100 * this.quantity;
				this.adventuringDayXP = 6000 * this.quantity;
				break;
			case "9":
				this.easyCharacterXP = 550 * this.quantity;
				this.mediumCharacterXP = 1100 * this.quantity;
				this.hardCharacterXP = 1600 * this.quantity;
				this.deadlyCharacterXP = 2400 * this.quantity;
				this.adventuringDayXP = 7500 * this.quantity;
				break;
			case "10":
				this.easyCharacterXP = 600 * this.quantity;
				this.mediumCharacterXP = 1200 * this.quantity;
				this.hardCharacterXP = 1900 * this.quantity;
				this.deadlyCharacterXP = 2800 * this.quantity;
				this.adventuringDayXP = 9000 * this.quantity;
				break;
			case "11":
				this.easyCharacterXP = 800 * this.quantity;
				this.mediumCharacterXP = 1600 * this.quantity;
				this.hardCharacterXP = 2400 * this.quantity;
				this.deadlyCharacterXP = 3600 * this.quantity;
				this.adventuringDayXP = 10500 * this.quantity;
				break;
			case "12":
				this.easyCharacterXP = 1000 * this.quantity;
				this.mediumCharacterXP = 2000 * this.quantity;
				this.hardCharacterXP = 3000 * this.quantity;
				this.deadlyCharacterXP = 4500 * this.quantity;
				this.adventuringDayXP = 11500 * this.quantity;
				break;
			case "13":
				this.easyCharacterXP = 1100 * this.quantity;
				this.mediumCharacterXP = 2200 * this.quantity;
				this.hardCharacterXP = 3400 * this.quantity;
				this.deadlyCharacterXP = 5100 * this.quantity;
				this.adventuringDayXP = 13500 * this.quantity;
				break;
			case "14":
				this.easyCharacterXP = 1250 * this.quantity;
				this.mediumCharacterXP = 2500 * this.quantity;
				this.hardCharacterXP = 3800 * this.quantity;
				this.deadlyCharacterXP = 5700 * this.quantity;
				this.adventuringDayXP = 15000 * this.quantity;
				break;
			case "15":
				this.easyCharacterXP = 1400 * this.quantity;
				this.mediumCharacterXP = 2800 * this.quantity;
				this.hardCharacterXP = 4300 * this.quantity;
				this.deadlyCharacterXP = 6400 * this.quantity;
				this.adventuringDayXP = 18000 * this.quantity;
				break;
			case "16":
				this.easyCharacterXP = 1600 * this.quantity;
				this.mediumCharacterXP = 3200 * this.quantity;
				this.hardCharacterXP = 4800 * this.quantity;
				this.deadlyCharacterXP = 7200 * this.quantity;
				this.adventuringDayXP = 20000 * this.quantity;
				break;
			case "17":
				this.easyCharacterXP = 2000 * this.quantity;
				this.mediumCharacterXP = 3900 * this.quantity;
				this.hardCharacterXP = 5900 * this.quantity;
				this.deadlyCharacterXP = 8800 * this.quantity;
				this.adventuringDayXP = 25000 * this.quantity;
				break;
			case "18":
				this.easyCharacterXP = 2100 * this.quantity;
				this.mediumCharacterXP = 4200 * this.quantity;
				this.hardCharacterXP = 6300 * this.quantity;
				this.deadlyCharacterXP = 9500 * this.quantity;
				this.adventuringDayXP = 27000 * this.quantity;
				break;
			case "19":
				this.easyCharacterXP = 2400 * this.quantity;
				this.mediumCharacterXP = 4900 * this.quantity;
				this.hardCharacterXP = 7300 * this.quantity;
				this.deadlyCharacterXP = 10900 * this.quantity;
				this.adventuringDayXP = 30000 * this.quantity;
				break;
			case "20":
				this.easyCharacterXP = 2800 * this.quantity;
				this.mediumCharacterXP = 5700 * this.quantity;
				this.hardCharacterXP = 8500 * this.quantity;
				this.deadlyCharacterXP = 12700 * this.quantity;
				this.adventuringDayXP = 40000 * this.quantity;
				break;
		}
    }

}
