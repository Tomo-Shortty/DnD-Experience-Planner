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
			throw new Exception("Character level has not been specified.")
        } 
		else
        {
			this.characterLevel = characterLevel;
		}
	}

	public string getCharacterLevel()
    {
		return this.characterLevel;
    }

	public int getEasyCharacterXP()
    {
		return this.easyCharacterXP;
    }

	public int getMediumCharacterXP()
    {
		return this.mediumCharacterXP;
    }

	public int getHardCharacterXP()
    {
		return this.hardCharacterXP;
    }

	public int getDeadlyCharacterXP()
    {
		return this.deadlyCharacterXP;
    }

	public int getAdventuringDayXP()
    {
		return this.adventuringDayXP;
    }

	public void setCharacterXP(string characterLevel)
    {
		switch(characterLevel)
        {
			case "1":
				this.getEasyCharacterXP() = 25;
				this.getMediumCharacterXP() = 50;
				this.getHardCharacterXP() = 75;
				this.getDeadlyCharacterXP() = 100;
				this.getAdventuringDayXP() = 300;
				break;
			case "2":
				this.getEasyCharacterXP() = 50;
				this.getMediumCharacterXP() = 100;
				this.getHardCharacterXP() = 150;
				this.getDeadlyCharacterXP() = 200;
				this.getAdventuringDayXP() = 600;
				break;
			case "3":
				this.getEasyCharacterXP() = 75;
				this.getMediumCharacterXP() = 150;
				this.getHardCharacterXP() = 225;
				this.getDeadlyCharacterXP() = 400;
				this.getAdventuringDayXP() = 1200;
				break;
			case "4":
				this.getEasyCharacterXP() = 125;
				this.getMediumCharacterXP() = 250;
				this.getHardCharacterXP() = 375;
				this.getDeadlyCharacterXP() = 500;
				this.getAdventuringDayXP() = 1700;
				break;
			case "5":
				this.getEasyCharacterXP() = 250;
				this.getMediumCharacterXP() = 500;
				this.getHardCharacterXP() = 750;
				this.getDeadlyCharacterXP() = 1100;
				this.getAdventuringDayXP() = 3500;
				break;
			case "6":
				this.getEasyCharacterXP() = 300;
				this.getMediumCharacterXP() = 600;
				this.getHardCharacterXP() = 900;
				this.getDeadlyCharacterXP() = 1400;
				this.getAdventuringDayXP() = 4000;
				break;
			case "7":
				this.getEasyCharacterXP() = 350;
				this.getMediumCharacterXP() = 750;
				this.getHardCharacterXP() = 1100;
				this.getDeadlyCharacterXP() = 1700;
				this.getAdventuringDayXP() = 5000;
				break;
			case "8":
				this.getEasyCharacterXP() = 450;
				this.getMediumCharacterXP() = 900;
				this.getHardCharacterXP() = 1400;
				this.getDeadlyCharacterXP() = 2100;
				this.getAdventuringDayXP() = 6000;
				break;
			case "9":
				this.getEasyCharacterXP() = 550;
				this.getMediumCharacterXP() = 1100;
				this.getHardCharacterXP() = 1600;
				this.getDeadlyCharacterXP() = 2400;
				this.getAdventuringDayXP() = 7500;
				break;
			case "10":
				this.getEasyCharacterXP() = 600;
				this.getMediumCharacterXP() = 1200;
				this.getHardCharacterXP() = 1900;
				this.getDeadlyCharacterXP() = 2800;
				this.getAdventuringDayXP() = 9000;
				break;
			case "11":
				this.getEasyCharacterXP() = 800;
				this.getMediumCharacterXP() = 1600;
				this.getHardCharacterXP() = 2400;
				this.getDeadlyCharacterXP() = 3600;
				this.getAdventuringDayXP() = 10500;
				break;
			case "12":
				this.getEasyCharacterXP() = 1000;
				this.getMediumCharacterXP() = 2000;
				this.getHardCharacterXP() = 3000;
				this.getDeadlyCharacterXP() = 4500;
				this.getAdventuringDayXP() = 11500;
				break;
			case "13":
				this.getEasyCharacterXP() = 1100;
				this.getMediumCharacterXP() = 2200;
				this.getHardCharacterXP() = 3400;
				this.getDeadlyCharacterXP() = 5100;
				this.getAdventuringDayXP() = 13500;
				break;
			case "14":
				this.getEasyCharacterXP() = 1250;
				this.getMediumCharacterXP() = 2500;
				this.getHardCharacterXP() = 3800;
				this.getDeadlyCharacterXP() = 5700;
				this.getAdventuringDayXP() = 15000;
				break;
			case "15":
				this.getEasyCharacterXP() = 1400;
				this.getMediumCharacterXP() = 2800;
				this.getHardCharacterXP() = 4300;
				this.getDeadlyCharacterXP() = 6400;
				this.getAdventuringDayXP() = 18000;
				break;
			case "16":
				this.getEasyCharacterXP() = 1600;
				this.getMediumCharacterXP() = 3200;
				this.getHardCharacterXP() = 4800;
				this.getDeadlyCharacterXP() = 7200;
				this.getAdventuringDayXP() = 20000;
				break;
			case "17":
				this.getEasyCharacterXP() = 2000;
				this.getMediumCharacterXP() = 3900;
				this.getHardCharacterXP() = 5900;
				this.getDeadlyCharacterXP() = 8800;
				this.getAdventuringDayXP() = 25000;
				break;
			case "18":
				this.getEasyCharacterXP() = 2100;
				this.getMediumCharacterXP() = 4200;
				this.getHardCharacterXP() = 6300;
				this.getDeadlyCharacterXP() = 9500;
				this.getAdventuringDayXP() = 27000;
				break;
			case "19":
				this.getEasyCharacterXP() = 2400;
				this.getMediumCharacterXP() = 4900;
				this.getHardCharacterXP() = 7300;
				this.getDeadlyCharacterXP() = 10900;
				this.getAdventuringDayXP() = 30000;
				break;
			case "20":
				this.getEasyCharacterXP() = 2800;
				this.getMediumCharacterXP() = 5700;
				this.getHardCharacterXP() = 8500;
				this.getDeadlyCharacterXP() = 12700;
				this.getAdventuringDayXP() = 40000;
				break;
		}
    }

}
