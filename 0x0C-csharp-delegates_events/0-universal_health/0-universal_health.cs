﻿using System;

/// <summary>
/// Defines a player.
/// </summary>
public class Player
{
	string name;
	float maxHp;
	float hp;

	/// <summary>
	/// Constructor for player.
	/// </summary>
	/// <param name="name">The name of the player.</param>
	/// <param name="maxHp">The player's maximum hit points.</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		if (maxHp <= 0)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		else
			this.maxHp = maxHp;
		this.name = name;
		this.hp = this.maxHp;
	}

	/// <summary>
	/// Prints the player's health.
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine("{0} has {1} / {2} health.", this.name, this.hp, this.maxHp);
	}
}
