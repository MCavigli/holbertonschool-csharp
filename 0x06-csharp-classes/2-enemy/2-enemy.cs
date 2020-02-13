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
		public int health;

		/// <summary>
		/// Basic constructor for zombie class.
		/// </summary>
		public Zombie()
		{ }

		/// <summary>
		/// Constructor for zombie class with health field.
		/// </summary>
		/// <param name="health">Represents a zombie instance's health.</param>
		public Zombie(int health)
		{
			if (health < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
		}
	}
}
