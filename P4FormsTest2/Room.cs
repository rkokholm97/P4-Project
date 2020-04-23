using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4FormsTest2
{
    public class Room
    {
        public int Number { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsSuite { get; set; }
        public int MaxOccupants { get; set; }

        public Room (int number, bool isAvailable, bool isSuite, int maxOccupants)
        {
            Number = number;
            IsAvailable = isAvailable;
            IsSuite = isSuite;
            MaxOccupants = maxOccupants;
        }
    }
}
