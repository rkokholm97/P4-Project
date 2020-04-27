using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4FormsTest2
{
    public class Room : IComparable
    {
        public int Number { get; set; }
        public bool IsSuite { get; set; }
        public int MaxOccupants { get; set; }

        public int Floor { get; set; }

        public int RowNumber { get; set; }

        public Room (int number, bool isSuite, int maxOccupants, int floor, int rowNumber)
        {
            Number = number;
            IsSuite = isSuite;
            MaxOccupants = maxOccupants;
            Floor = floor;
            RowNumber = RowNumber;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Room otherRoom = obj as Room;
            if (otherRoom != null)
                return this.Number.CompareTo(otherRoom.Number);
            else
                throw new ArgumentException("Object is not a Room");
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
