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

	public string GetChallengeRating()
    {
		return this.challengeRating;
    }

	public int GetMonsterXP()
    {
		return this.monsterXP;
    }

	public void SetMonsterXP(string challengeRating)
    {
		switch (challengeRating)
        {
			case "0":
				this.monsterXP = 10;
				break;
			case "1/8":
				this.monsterXP = 25;
				break;
			case "1/4":
				this.monsterXP = 50;
				break;
			case "1/2":
				this.monsterXP = 100;
				break;
			case "1":
				this.monsterXP = 200;
				break;
			case "2":
				this.monsterXP = 450;
				break;
			case "3":
				this.monsterXP = 700;
				break;
			case "4":
				this.monsterXP = 1100;
				break;
			case "5":
				this.monsterXP = 1800;
				break;
			case "6":
				this.monsterXP = 2300;
				break;
			case "7":
				this.monsterXP = 2900;
				break;
			case "8":
				this.monsterXP = 3900;
				break;
			case "9":
				this.monsterXP = 5000;
				break;
			case "10":
				this.monsterXP = 5900;
				break;
			case "11":
				this.monsterXP = 7200;
				break;
			case "12":
				this.monsterXP = 8400;
				break;
			case "13":
				this.monsterXP = 10000;
				break;
			case "14":
				this.monsterXP = 11500;
				break;
			case "15":
				this.monsterXP = 13000;
				break;
			case "16":
				this.monsterXP = 15000;
				break;
			case "17":
				this.monsterXP = 18000;
				break;
			case "18":
				this.monsterXP = 20000;
				break;
			case "19":
				this.monsterXP = 22000;
				break;
			case "20":
				this.monsterXP = 25000;
				break;
			case "21":
				this.monsterXP = 33000;
				break;
			case "22":
				this.monsterXP = 41000;
				break;
			case "23":
				this.monsterXP = 50000;
				break;
			case "24":
				this.monsterXP = 62000;
				break;
			case "25":
				this.monsterXP = 75000;
				break;
			case "26":
				this.monsterXP = 90000;
				break;
			case "27":
				this.monsterXP = 105000;
				break;
			case "28":
				this.monsterXP = 120000;
				break;
			case "29":
				this.monsterXP = 135000;
				break;
			case "30":
				this.monsterXP = 155000;
				break;
		}
    }
}
