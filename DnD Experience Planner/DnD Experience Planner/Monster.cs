using System;

public class Monster
{
	private string challengeRating;
	private int quantity;
	private int monsterXP;

	/*
	 * Constructor for the Monster class. Throws an exception if challenge rating is empty or quantity is equal to or less than 0.
	 */
	public Monster(string challengeRating, int quantity)
	{
		if (challengeRating.Equals(""))
        {
			throw new Exception("Challenge Rating not selected.");
        } 
		else if (quantity <= 0)
        {
			throw new Exception("Number of monsters has not been specified");
        }
		else
        {
			this.challengeRating = challengeRating;
			this.quantity = quantity;
        }
	}

	/*
	 * Gets the challenge rating.
	 */
	public string GetChallengeRating()
    {
		return this.challengeRating;
    }

	/*
	 * Gets the quanity.
	 */
	public int GetNumberOfMonsters()
    {
		return this.quantity;
    }

	/*
	 * Gets the monster's experience.
	 */
	public int GetMonsterXP()
    {
		return this.monsterXP;
    }

	/*
	 * Determines the monster experience to assign based on the challenge rating.
	 */
	public void SetMonsterXP(string challengeRating)
    {
		switch (challengeRating)
        {
			case "0":
				this.monsterXP = 10 * this.quantity;
				break;
			case "1/8":
				this.monsterXP = 25 * this.quantity;
				break;
			case "1/4":
				this.monsterXP = 50 * this.quantity;
				break;
			case "1/2":
				this.monsterXP = 100 * this.quantity;
				break;
			case "1":
				this.monsterXP = 200 * this.quantity;
				break;
			case "2":
				this.monsterXP = 450 * this.quantity;
				break;
			case "3":
				this.monsterXP = 700 * this.quantity;
				break;
			case "4":
				this.monsterXP = 1100 * this.quantity;
				break;
			case "5":
				this.monsterXP = 1800 * this.quantity;
				break;
			case "6":
				this.monsterXP = 2300 * this.quantity;
				break;
			case "7":
				this.monsterXP = 2900 * this.quantity;
				break;
			case "8":
				this.monsterXP = 3900 * this.quantity;
				break;
			case "9":
				this.monsterXP = 5000 * this.quantity;
				break;
			case "10":
				this.monsterXP = 5900 * this.quantity;
				break;
			case "11":
				this.monsterXP = 7200 * this.quantity;
				break;
			case "12":
				this.monsterXP = 8400 * this.quantity;
				break;
			case "13":
				this.monsterXP = 10000 * this.quantity;
				break;
			case "14":
				this.monsterXP = 11500 * this.quantity;
				break;
			case "15":
				this.monsterXP = 13000 * this.quantity;
				break;
			case "16":
				this.monsterXP = 15000 * this.quantity;
				break;
			case "17":
				this.monsterXP = 18000 * this.quantity;
				break;
			case "18":
				this.monsterXP = 20000 * this.quantity;
				break;
			case "19":
				this.monsterXP = 22000 * this.quantity;
				break;
			case "20":
				this.monsterXP = 25000 * this.quantity;
				break;
			case "21":
				this.monsterXP = 33000 * this.quantity;
				break;
			case "22":
				this.monsterXP = 41000 * this.quantity;
				break;
			case "23":
				this.monsterXP = 50000 * this.quantity;
				break;
			case "24":
				this.monsterXP = 62000 * this.quantity;
				break;
			case "25":
				this.monsterXP = 75000 * this.quantity;
				break;
			case "26":
				this.monsterXP = 90000 * this.quantity;
				break;
			case "27":
				this.monsterXP = 105000 * this.quantity;
				break;
			case "28":
				this.monsterXP = 120000 * this.quantity;
				break;
			case "29":
				this.monsterXP = 135000 * this.quantity;
				break;
			case "30":
				this.monsterXP = 155000 * this.quantity;
				break;
		}
    }
}
