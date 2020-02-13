using System;

namespace Enemies
{
	/// <summary>
	/// Provides a template for a zombie enemy.
	/// </summary>
	public class Zombie
	{
		/// <summary>
		/// Represents a zombie instance's health.
		/// </summary>
		private int health;

		/// <summary>
		/// Represents the name of the zombie.
		/// </summary>
		private string name = "(No name)";

		/// <summary>
		/// Getter and setter for zombie's name.
		/// </summary>
		/// <value>Gets and sets the value of name.</value>
		public string Name
		{
			get { return (name); }
			set
			{ name = value; }
		}

		/// <summary>
		/// Method that retrieves the health of a zombie instance.
		/// </summary>
		/// <returns>The zombie isntance's health.</returns>
		public int GetHealth()
		{
			return (this.health);
		}

		/// <summary>
		/// Defines a custom toString() method.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Zombie name: " + name + " / Total Health: " + health;
		}

		/// <summary>
		/// Basic constructor for zombie class.
		/// </summary>
		public Zombie()
		{ }

		/// <summary>
		/// Constructor for zombie class with health field.
		/// </summary>
		/// <param name="value">Represents a zombie instance's health.</param>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			health = value;
		}
	}
}
