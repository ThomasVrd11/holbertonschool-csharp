using System;

namespace Enemies
{
    /// <summary> blueprint for zombie. </summary>
    public class Zombie 
    {
         /// <summary> Health </summary>
        public int health;

        /// <summary> new instance of a zombie </summary>
        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
    }
}