namespace POO.Entities;

public class Ninja : Hero
{
	public Ninja(string name, int level, string heroType)
	{
		this.Name = name;
		this.Level = level;
		this.HeroType = heroType;
	}
	
	public string Attack()
	{
		return this.Name + " Lançou shuriken";
	}

	public string Attack(int Bonus)
	{
		if (Bonus > 6)
		{
			return this.Name + " Atacou com a katana com bônus de ataque de " + Bonus;
		}
		else
		{
			return this.Name + " Lançou shuriken tripla com bônus de ataque de " + Bonus;
		}
	}
}
