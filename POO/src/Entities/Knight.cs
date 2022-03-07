namespace POO.Entities;

public class Knight : Hero
{
	public Knight(string name, int level, string heroType)
	{
		this.Name = name;
		this.Level = level;
		this.HeroType = heroType;
	}
	
	public string Attack()
	{
		return this.Name + " Atacou com a espada";
	}

	public string Attack(int Bonus)
	{
		if (Bonus > 6)
		{
			return this.Name + " Atacou com a espada em fúria com bônus de ataque de " + Bonus;
		}
		else
		{
			return this.Name + " Atacou com a espada sem fúria com bônus de ataque de " + Bonus;
		}
	}
}
