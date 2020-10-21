using System;

public class Monster
{
	private string challengeRating;
	private int monsterXP;

	public Monster(string challengeRating)
	{
		if (challengeRating.Equals(""))
        {
			throw new Exception("Challenge Rating not selected.");
        } else
        {
			this.challengeRating = challengeRating;
        }
	}

	public string getChallengeRating()
    {
		return this.challengeRating;
    }

	public int getMonsterXP()
    {
		return this.monsterXP;
    }

	public void setMonsterXP(string challengeRating)
    {
		switch (challengeRating)
        {
			case "0":
				this.getMonsterXP() = 10;
				break;
			case "1/8":
				this.getMonsterXP() = 25;
				break;
			case "1/4":
				this.getMonsterXP() = 50;
				break;
			case "1/2":
				this.getMonsterXP() = 100;
				break;
			case "1":
				this.getMonsterXP() = 200;
				break;
			case "2":
				this.getMonsterXP() = 450;
				break;
			case "3":
				this.getMonsterXP() = 700;
				break;
			case "4":
				this.getMonsterXP() = 1100;
				break;
			case "5":
				this.getMonsterXP() = 1800;
				break;
			case "6":
				this.getMonsterXP() = 2300;
				break;
			case "7":
				this.getMonsterXP() = 2900;
				break;
			case "8":
				this.getMonsterXP() = 3900;
				break;
			case "9":
				this.getMonsterXP() = 5000;
				break;
			case "10":
				this.getMonsterXP() = 5900;
				break;
			case "11":
				this.getMonsterXP() = 7200;
				break;
			case "12":
				this.getMonsterXP() = 8400;
				break;
			case "13":
				this.getMonsterXP() = 10000;
				break;
			case "14":
				this.getMonsterXP() = 11500;
				break;
			case "15":
				this.getMonsterXP() = 13000;
				break;
			case "16":
				this.getMonsterXP() = 15000;
				break;
			case "17":
				this.getMonsterXP() = 18000;
				break;
			case "18":
				this.getMonsterXP() = 20000;
				break;
			case "19":
				this.getMonsterXP() = 22000;
				break;
			case "20":
				this.getMonsterXP() = 25000;
				break;
			case "21":
				this.getMonsterXP() = 33000;
				break;
			case "22":
				this.getMonsterXP() = 41000;
				break;
			case "23":
				this.getMonsterXP() = 50000;
				break;
			case "24":
				this.getMonsterXP() = 62000;
				break;
			case "25":
				this.getMonsterXP() = 75000;
				break;
			case "26":
				this.getMonsterXP() = 90000;
				break;
			case "27":
				this.getMonsterXP() = 105000;
				break;
			case "28":
				this.getMonsterXP() = 120000;
				break;
			case "29":
				this.getMonsterXP() = 135000;
				break;
			case "30":
				this.getMonsterXP() = 155000;
				break;
		}
    }
}
