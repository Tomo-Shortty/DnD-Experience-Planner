using System;

public class Character
{
	private string characterLevel;
	private int easyCharacterXP;
	private int mediumCharacterXP;
	private int hardCharacterXP;
	private int deadlyCharacterXP;
	private int adventuringDayXP;

	public Character(string characterLevel)
	{
		if (characterLevel.Equals(""))
        {
			throw new Exception("Character level has not been specified.");
        } 
		else
        {
			this.characterLevel = characterLevel;
		}
	}

	public string GetCharacterLevel()
    {
		return this.characterLevel;
    }

	public int GetEasyCharacterXP()
    {
		return this.easyCharacterXP;
    }

	public int GetMediumCharacterXP()
    {
		return this.mediumCharacterXP;
    }

	public int GetHardCharacterXP()
    {
		return this.hardCharacterXP;
    }

	public int GetDeadlyCharacterXP()
    {
		return this.deadlyCharacterXP;
    }

	public int GetAdventuringDayXP()
    {
		return this.adventuringDayXP;
    }

	public void SetCharacterXP(string characterLevel)
    {
		switch(characterLevel)
        {
			case "1":
				this.easyCharacterXP = 25;
				this.mediumCharacterXP = 50;
				this.hardCharacterXP = 75;
				this.deadlyCharacterXP = 100;
				this.adventuringDayXP = 300;
				break;
			case "2":
				this.easyCharacterXP = 50;
				this.mediumCharacterXP = 100;
				this.hardCharacterXP = 150;
				this.deadlyCharacterXP = 200;
				this.adventuringDayXP = 600;
				break;
			case "3":
				this.easyCharacterXP = 75;
				this.mediumCharacterXP = 150;
				this.hardCharacterXP = 225;
				this.deadlyCharacterXP = 400;
				this.adventuringDayXP = 1200;
				break;
			case "4":
				this.easyCharacterXP = 125;
				this.mediumCharacterXP = 250;
				this.hardCharacterXP = 375;
				this.deadlyCharacterXP = 500;
				this.adventuringDayXP = 1700;
				break;
			case "5":
				this.easyCharacterXP = 250;
				this.mediumCharacterXP = 500;
				this.hardCharacterXP = 750;
				this.deadlyCharacterXP = 1100;
				this.adventuringDayXP = 3500;
				break;
			case "6":
				this.easyCharacterXP = 300;
				this.mediumCharacterXP = 600;
				this.hardCharacterXP = 900;
				this.deadlyCharacterXP = 1400;
				this.adventuringDayXP = 4000;
				break;
			case "7":
				this.easyCharacterXP = 350;
				this.mediumCharacterXP = 750;
				this.hardCharacterXP = 1100;
				this.deadlyCharacterXP = 1700;
				this.adventuringDayXP = 5000;
				break;
			case "8":
				this.easyCharacterXP = 450;
				this.mediumCharacterXP = 900;
				this.hardCharacterXP = 1400;
				this.deadlyCharacterXP = 2100;
				this.adventuringDayXP = 6000;
				break;
			case "9":
				this.easyCharacterXP = 550;
				this.mediumCharacterXP = 1100;
				this.hardCharacterXP = 1600;
				this.deadlyCharacterXP = 2400;
				this.adventuringDayXP = 7500;
				break;
			case "10":
				this.easyCharacterXP = 600;
				this.mediumCharacterXP = 1200;
				this.hardCharacterXP = 1900;
				this.deadlyCharacterXP = 2800;
				this.adventuringDayXP = 9000;
				break;
			case "11":
				this.easyCharacterXP = 800;
				this.mediumCharacterXP = 1600;
				this.hardCharacterXP = 2400;
				this.deadlyCharacterXP = 3600;
				this.adventuringDayXP = 10500;
				break;
			case "12":
				this.easyCharacterXP = 1000;
				this.mediumCharacterXP = 2000;
				this.hardCharacterXP = 3000;
				this.deadlyCharacterXP = 4500;
				this.adventuringDayXP = 11500;
				break;
			case "13":
				this.easyCharacterXP = 1100;
				this.mediumCharacterXP = 2200;
				this.hardCharacterXP = 3400;
				this.deadlyCharacterXP = 5100;
				this.adventuringDayXP = 13500;
				break;
			case "14":
				this.easyCharacterXP = 1250;
				this.mediumCharacterXP = 2500;
				this.hardCharacterXP = 3800;
				this.deadlyCharacterXP = 5700;
				this.adventuringDayXP = 15000;
				break;
			case "15":
				this.easyCharacterXP = 1400;
				this.mediumCharacterXP = 2800;
				this.hardCharacterXP = 4300;
				this.deadlyCharacterXP = 6400;
				this.adventuringDayXP = 18000;
				break;
			case "16":
				this.easyCharacterXP = 1600;
				this.mediumCharacterXP = 3200;
				this.hardCharacterXP = 4800;
				this.deadlyCharacterXP = 7200;
				this.adventuringDayXP = 20000;
				break;
			case "17":
				this.easyCharacterXP = 2000;
				this.mediumCharacterXP = 3900;
				this.hardCharacterXP = 5900;
				this.deadlyCharacterXP = 8800;
				this.adventuringDayXP = 25000;
				break;
			case "18":
				this.easyCharacterXP = 2100;
				this.mediumCharacterXP = 4200;
				this.hardCharacterXP = 6300;
				this.deadlyCharacterXP = 9500;
				this.adventuringDayXP = 27000;
				break;
			case "19":
				this.easyCharacterXP = 2400;
				this.mediumCharacterXP = 4900;
				this.hardCharacterXP = 7300;
				this.deadlyCharacterXP = 10900;
				this.adventuringDayXP = 30000;
				break;
			case "20":
				this.easyCharacterXP = 2800;
				this.mediumCharacterXP = 5700;
				this.hardCharacterXP = 8500;
				this.deadlyCharacterXP = 12700;
				this.adventuringDayXP = 40000;
				break;
		}
    }

}
