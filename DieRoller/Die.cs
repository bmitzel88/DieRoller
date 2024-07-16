using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {
        private static Random _random;

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// Creates the die and rolls it to start with a random number
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The current value that was rolled
        /// </summary>
        public byte RolledValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool isHeld { get; set; }

        // Get the rolled value (value that was rolled)
        // Is the die held?

        // Roll the die (set a new random face up value)
        
        /// <summary>
        /// Rolls the die and sets the <see cref="RolledValue"/> to the value
        /// that was rolled.
        /// </summary>
        /// <returns>Returns the new RolledValue</returns>
        public byte Roll() 
        {
            


            // Check if the die is held by another player
            if (!isHeld)
            {

                // Generate random number
                byte newValue = (byte)_random.Next(1, 7);


                // Set to RolledValue
                RolledValue = newValue;
                // Return RolledValue
                return RolledValue;
                throw new NotImplementedException();
            }
            else 
            {
                return RolledValue;
            }
            
        }

    }
}
