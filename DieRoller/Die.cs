using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The current value that was rolled
        /// </summary>
        public byte RolledValue { get; set; }

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
            // Generate random number
            // Set to RolledValue
            // Return RolledValue
            throw new NotImplementedException();
        }

    }
}
