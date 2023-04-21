using System;

namespace Enemies
{
    /// <summary> Public class that defines a Zombie </summary>
    public class Zombie
    {
        /// <summary> Public int named health</summary>
        private int health;

        /// <summary> Public constructor Zombie without parameters </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary> Public constructor Zombie with parameters </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        /// <summary> Public health variable getter</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
