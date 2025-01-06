using System;

namespace Enemies
{
    /// <summary> Class of a zombie </summary>
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        /// <summary> Constructor </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary> Constructor for a new instance of the zombie class with a given health value. </summary>
        public Zombie(int value)
        {
            if (value < 0) throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary> Gets sets zombie name </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary> Method that returns the value of Zombie health </summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary> Override that prints the zombie attribute to stdout </summary>
        public .toString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}