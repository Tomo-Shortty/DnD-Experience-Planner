using System;

public class Monster
{
	private string challengeRating;
	private int XP;

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

	public int getXP()
    {
		return this.XP;
    }
}
