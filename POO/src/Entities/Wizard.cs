namespace POO.Entities;

public class Wizard : Hero
{
	public Wizard(string name, int level, string heroType)
	{
		this.Name = name;
		this.Level = level;
		this.HeroType = heroType;
	}
	
	public string Attack()
	{
		return this.Name + " Lançou magia";
	}

	public string Attack(int Bonus)
	{
		if (Bonus > 6)
		{
			return this.Name + " Lançou magia arcana com bônus de ataque de " + Bonus;
		}
		else
		{
			return this.Name + " Lançou magia de gelo com bônus de ataque de " + Bonus;
		}
	}
}
