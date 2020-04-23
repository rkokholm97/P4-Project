using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4FormsTest2
{
    public class Reservation
    {
        public static int TotalId { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public Room Room { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Reservation (string name, Room room, DateTime start, DateTime end, string phoneNumber, string email, int numberOfAdults, int numberOfChildren)
        {
            Name = name;
            Room = room;
            Start = start;
            End = end;
            PhoneNumber = phoneNumber;
            Email = email;
            NumberOfAdults = numberOfAdults;
            NumberOfChildren = numberOfChildren;
            NumberOfGuests = numberOfAdults + numberOfChildren;
            TotalId = TotalId + 1;
            Id = TotalId; 
        }
    }
}
